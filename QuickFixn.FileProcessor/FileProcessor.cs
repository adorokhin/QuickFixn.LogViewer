using QuickFixn.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixn.LogFileProcessor
{
    public class QuickFIXLogFileProcessor
    {
        const Int32 BUFFERSIZE = 1024; //16384;
        public FIXConverter FIXConverter { set; private get; }
        public string FileName { set; private get; }

        public QuickFIXLogFileProcessor()
        {
        }

        public void ProcessFileAsync()
        {
            var sw = Stopwatch.StartNew();
            FileInfo f = new FileInfo(FileName);
            long fileSize = f.Length;

            List<StreamLimits> streamLimits = GetStreamLimits();
            List<Task<int>> convTasks = new List<Task<int>>();

            foreach (var sl in streamLimits)
            {
                convTasks.Add(ProcessChunk(sl));
                Console.WriteLine(sl.ToString());
            }

            Task.WaitAll(convTasks.ToArray());
            sw.Stop();

            int lines = 0;
            foreach (var item in convTasks)
            {
                int line = item.Result;
                lines += line;
                Console.WriteLine("TaskID:{0} Lines Processed: {1}", item.Id, line);
            }
            Console.WriteLine("Total Lines Processed: {0} Took {1} sec.  Speed: {2} rec/sec", lines, sw.ElapsedMilliseconds / 1000, lines / (sw.ElapsedMilliseconds / 1000.0));

            //while (convTasks.Count > 0)
            //{
            //    Task<int> firstFinishedTask = Task<int>.WhenAny(convTasks);
            //    convTasks.Remove(firstFinishedTask);
            //    //int lines = firstFinishedTask.Result;
            //    //Console.WriteLine("{0} {1}", firstFinishedTask.Id, lines);
            //}
        }

        private Task<int> ProcessChunk(StreamLimits sl)
        {
            Task<int> chunk = Task<int>.Factory.StartNew(() =>
            {
                string dumpFileName = string.Format("{0}.{1}.dump", FileName, Task.CurrentId);
                string line;
                int lines = 0;
                using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
                using (System.IO.StreamWriter dumpFile = new System.IO.StreamWriter(dumpFileName, false))
                {
                    fs.Seek(sl.startPosition, SeekOrigin.Begin);
                    using (StreamReader streamReader = new StreamReader(fs))
                    {
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            try
                            {
                                //Console.WriteLine("{0} {1}", Task.CurrentId, line);
                                
                                var xe = FIXConverter.BuildXMLFromString(line);
                                lines++;
                                if (streamReader.BaseStream.Position >= sl.endPosition)
                                    break;
                                else
                                    dumpFile.WriteLine(line);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
                return lines;
            });
            return chunk;
        }

        private List<StreamLimits> GetStreamLimits()
        {
            FileInfo f = new FileInfo(FileName);
            long fileSize = f.Length;
            int numConversionThreads = (int)(fileSize / BUFFERSIZE);
            if (numConversionThreads > 6)
                numConversionThreads = 6;
            if (numConversionThreads == 0)
                numConversionThreads = 1;
            int chunkSize = (int)(fileSize / numConversionThreads);
            long currStreamStart = 0;
            long currStreamEnd = chunkSize;

            List<StreamLimits> streamLimits = new List<StreamLimits>(numConversionThreads);

            using (Stream input = File.OpenRead(FileName))
            {
                for (int i = 0; i < numConversionThreads; i++)
                {
                    input.Position = currStreamEnd;
                    var sl = new StreamLimits(currStreamStart, currStreamEnd);
                    bool eol = false;
                    while (!eol)
                    {
                        int c = input.ReadByte();
                        if (c == -1)
                        {
                            break;
                        }
                        if ((char)c == '\n')
                        {
                            eol = true;
                        }
                        currStreamEnd++;
                    }
                    
                    if (currStreamEnd > input.Length)
                        currStreamEnd = input.Length;

                    currStreamStart = currStreamEnd;                    
                    sl.endPosition = currStreamEnd;
                    currStreamEnd += chunkSize;
                    streamLimits.Add(sl);

                }
            }

            return streamLimits;
        }
    }
}
