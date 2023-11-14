using QuickFix.Fields;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickFixn.LogViewer.WPF.Colors
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class PantoneColor
    {
        public readonly string _name;
        public readonly string _color;
        
        public PantoneColor(string name, string color)
        {
            _name = name;
            _color = color;

        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{_name}:{_color}";
        }
    }
    
    public class PantoneColors
    {
        public static Dictionary<int, PantoneColor> Colors = new Dictionary<int, PantoneColor>()
        {
            {1,  new PantoneColor("100", "#f4ed7c")},
            {2,  new PantoneColor("100 C", "#f7ea5f")},
            {3,  new PantoneColor("100 U", "#fef27e")},
            {4,  new PantoneColor("101", "#f4ed47")},
            {5,  new PantoneColor("101 C", "#f8e946")},
            {6,  new PantoneColor("101 U", "#ffef65")},
            {7,  new PantoneColor("102", "#f9e814")},
            {8,  new PantoneColor("102 C", "#fde300")},
            {9,  new PantoneColor("102 U", "#ffec28")},
            {10,  new PantoneColor("103", "#c6ad0f")},
            {11,  new PantoneColor("103 C", "#c6a900")},
            {12,  new PantoneColor("103 U", "#b59e28")},
            {13,  new PantoneColor("104", "#ad9b0c")},
            {14,  new PantoneColor("104 C", "#b19700")},
            {15,  new PantoneColor("104 U", "#9b8c37")},
            {16,  new PantoneColor("105", "#82750f")},
            {17,  new PantoneColor("105 C", "#8b7a27")},
            {18,  new PantoneColor("105 U", "#7d7446")},
            {19,  new PantoneColor("106", "#f7e859")},
            {20,  new PantoneColor("106 C", "#fbe343")},
            {21,  new PantoneColor("106 U", "#ffea65")},
            {22,  new PantoneColor("107", "#f9e526")},
            {23,  new PantoneColor("107 C", "#fee01e")},
            {24,  new PantoneColor("107 U", "#ffe450")},
            {25,  new PantoneColor("108", "#f9dd16")},
            {26,  new PantoneColor("108 U", "#ffdc32")},
            {27,  new PantoneColor("109", "#f9d616")},
            {28,  new PantoneColor("109 C", "#ffd100")},
            {29,  new PantoneColor("109 U", "#ffc700")},
            {30,  new PantoneColor("110", "#d8b511")},
            {31,  new PantoneColor("110 C", "#dba900")},
            {32,  new PantoneColor("110 U", "#cd9f24")},
            {33,  new PantoneColor("111", "#aa930a")},
            {34,  new PantoneColor("111 C", "#ac8900")},
            {35,  new PantoneColor("111 U", "#9b8638")},
            {36,  new PantoneColor("112", "#99840a")},
            {37,  new PantoneColor("112 C", "#9d830f")},
            {38,  new PantoneColor("112 U", "#8a7a3e")},
            {39,  new PantoneColor("113", "#f9e55b")},
            {40,  new PantoneColor("113 C", "#fddf50")},
            {41,  new PantoneColor("113 U", "#ffe05e")},
            {42,  new PantoneColor("114", "#f9e24c")},
            {43,  new PantoneColor("114 C", "#fedd3c")},
            {44,  new PantoneColor("114 U", "#ffd847")},
            {45,  new PantoneColor("115", "#f9e04c")},
            {46,  new PantoneColor("115 C", "#ffd923")},
            {47,  new PantoneColor("115 U", "#ffcd29")},
            {48,  new PantoneColor("116", "#fcd116")},
            {49,  new PantoneColor("116 C", "#ffcd00")},
            {50,  new PantoneColor("116 U", "#ffb408")},
            {51,  new PantoneColor("117", "#c6a00c")},
            {52,  new PantoneColor("117 C", "#cc9700")},
            {53,  new PantoneColor("117 U", "#b78b2e")},
            {54,  new PantoneColor("118", "#aa8e0a")},
            {55,  new PantoneColor("118 C", "#ae8400")},
            {56,  new PantoneColor("118 U", "#9e8038")},
            {57,  new PantoneColor("119", "#897719")},
            {58,  new PantoneColor("119 C", "#8a731f")},
            {59,  new PantoneColor("119 U", "#847647")},
            {60,  new PantoneColor("120", "#f9e27f")},
            {61,  new PantoneColor("120 C", "#feda63")},
            {62,  new PantoneColor("120 U", "#ffd968")},
            {63,  new PantoneColor("1205", "#f7e8aa")},
            {64,  new PantoneColor("1205 C", "#f9df8d")},
            {65,  new PantoneColor("1205 U", "#ffe394")},
            {66,  new PantoneColor("121", "#f9e070")},
            {67,  new PantoneColor("121 C", "#ffd755")},
            {68,  new PantoneColor("121 U", "#ffcb50")},
            {69,  new PantoneColor("1215", "#f9e08c")},
            {70,  new PantoneColor("1215 C", "#fed671")},
            {71,  new PantoneColor("1215 U", "#ffd97c")},
            {72,  new PantoneColor("122", "#fcd856")},
            {73,  new PantoneColor("122 C", "#ffd03e")},
            {74,  new PantoneColor("122 U", "#ffc03d")},
            {75,  new PantoneColor("1225", "#ffcc49")},
            {76,  new PantoneColor("1225 C", "#ffc842")},
            {77,  new PantoneColor("1225 U", "#ffba4d")},
            {78,  new PantoneColor("123", "#ffc61e")},
            {79,  new PantoneColor("123 C", "#ffc627")},
            {80,  new PantoneColor("123 U", "#ffac25")},
            {81,  new PantoneColor("1235", "#fcb514")},
            {82,  new PantoneColor("1235 C", "#ffb718")},
            {83,  new PantoneColor("1235 U", "#ffad38")},
            {84,  new PantoneColor("124", "#e0aa0f")},
            {85,  new PantoneColor("124 C", "#eda900")},
            {86,  new PantoneColor("124 U", "#d99132")},
            {87,  new PantoneColor("1245", "#bf910c")},
            {88,  new PantoneColor("1245 C", "#c9910d")},
            {89,  new PantoneColor("1245 U", "#bb8a3f")},
            {90,  new PantoneColor("125", "#b58c0a")},
            {91,  new PantoneColor("125 C", "#b78400")},
            {92,  new PantoneColor("125 U", "#a6803a")},
            {93,  new PantoneColor("1255", "#a37f14")},
            {94,  new PantoneColor("1255 C", "#af841d")},
            {95,  new PantoneColor("1255 U", "#a18045")},
            {96,  new PantoneColor("126", "#a38205")},
            {97,  new PantoneColor("126 C", "#9d760c")},
            {98,  new PantoneColor("126 U", "#8e7641")},
            {99,  new PantoneColor("1265", "#7c6316")},
            {100,  new PantoneColor("1265 C", "#8a6b24")},
            {101,  new PantoneColor("1265 U", "#887447")},
            {102,  new PantoneColor("127", "#f4e287")},
            {103,  new PantoneColor("127 C", "#f5db6b")},
            {104,  new PantoneColor("127 U", "#fce182")},
            {105,  new PantoneColor("128", "#f4db60")},
            {106,  new PantoneColor("128 C", "#f7d44b")},
            {107,  new PantoneColor("128 U", "#fecd60")},
            {108,  new PantoneColor("129", "#f2d13d")},
            {109,  new PantoneColor("129 C", "#f6ce3c")},
            {110,  new PantoneColor("129 U", "#fead3c")},
            {111,  new PantoneColor("130", "#eaaf0f")},
            {112,  new PantoneColor("130 C", "#f7a700")},
            {113,  new PantoneColor("130 U", "#fc992e")},
            {114,  new PantoneColor("131", "#c6930a")},
            {115,  new PantoneColor("131 C", "#d08900")},
            {116,  new PantoneColor("131 U", "#be7e33")},
            {117,  new PantoneColor("132", "#9e7c0a")},
            {118,  new PantoneColor("132 C", "#a37300")},
            {119,  new PantoneColor("132 U", "#99793d")},
            {120,  new PantoneColor("133", "#705b0a")},
            {121,  new PantoneColor("133 C", "#6e561b")},
            {122,  new PantoneColor("133 U", "#7c6f46")},
            {123,  new PantoneColor("134", "#ffd87f")},
            {124,  new PantoneColor("134 C", "#ffd16c")},
            {125,  new PantoneColor("134 U", "#ffd276")},
            {126,  new PantoneColor("1345", "#ffd691")},
            {127,  new PantoneColor("1345 C", "#fecf84")},
            {128,  new PantoneColor("1345 U", "#ffd490")},
            {129,  new PantoneColor("135", "#fcc963")},
            {130,  new PantoneColor("135 C", "#ffc556")},
            {131,  new PantoneColor("135 U", "#ffc265")},
            {132,  new PantoneColor("1355", "#fcce87")},
            {133,  new PantoneColor("1355 C", "#ffc56c")},
            {134,  new PantoneColor("1355 U", "#ffc87e")},
            {135,  new PantoneColor("136", "#fcbf49")},
            {136,  new PantoneColor("136 C", "#ffbf3b")},
            {137,  new PantoneColor("136 U", "#ffac48")},
            {138,  new PantoneColor("1365", "#fcba5e")},
            {139,  new PantoneColor("1365 C", "#ffb546")},
            {140,  new PantoneColor("1365 U", "#ffac5a")},
            {141,  new PantoneColor("137", "#fca311")},
            {142,  new PantoneColor("137 C", "#ffa300")},
            {143,  new PantoneColor("137 U", "#ffa035")},
            {144,  new PantoneColor("1375", "#f99b0c")},
            {145,  new PantoneColor("1375 C", "#ff9e15")},
            {146,  new PantoneColor("1375 U", "#ff993e")},
            {147,  new PantoneColor("138", "#d88c02")},
            {148,  new PantoneColor("138 C", "#e17c00")},
            {149,  new PantoneColor("138 U", "#d57b2f")},
            {150,  new PantoneColor("1385", "#cc7a02")},
            {151,  new PantoneColor("1385 C", "#d87800")},
            {152,  new PantoneColor("1385 U", "#cf7d3d")},
            {153,  new PantoneColor("139", "#af7505")},
            {154,  new PantoneColor("139 C", "#b26d00")},
            {155,  new PantoneColor("139 U", "#9e6e3c")},
            {156,  new PantoneColor("1395", "#996007")},
            {157,  new PantoneColor("1395 C", "#9c5f15")},
            {158,  new PantoneColor("1395 U", "#956d42")},
            {159,  new PantoneColor("140", "#7a5b11")},
            {160,  new PantoneColor("140 C", "#755319")},
            {161,  new PantoneColor("140 U", "#806944")},
            {162,  new PantoneColor("1405", "#6b4714")},
            {163,  new PantoneColor("1405 C", "#704b1c")},
            {164,  new PantoneColor("1405 U", "#7a6446")},
            {165,  new PantoneColor("141", "#f2ce68")},
            {166,  new PantoneColor("141 C", "#f6c55b")},
            {167,  new PantoneColor("141 U", "#fbbf6d")},
            {168,  new PantoneColor("142", "#f2bf49")},
            {169,  new PantoneColor("142 C", "#f5bd47")},
            {170,  new PantoneColor("142 U", "#fbae5c")},
            {171,  new PantoneColor("143", "#efb22d")},
            {172,  new PantoneColor("143 C", "#f6b333")},
            {173,  new PantoneColor("143 U", "#fb9e4e")},
            {174,  new PantoneColor("144", "#e28c05")},
            {175,  new PantoneColor("144 C", "#f38a00")},
            {176,  new PantoneColor("144 U", "#f78a3b")},
            {177,  new PantoneColor("145", "#c67f07")},
            {178,  new PantoneColor("145 C", "#d57e00")},
            {179,  new PantoneColor("145 U", "#cc7d38")},
            {180,  new PantoneColor("146", "#9e6b05")},
            {181,  new PantoneColor("146 C", "#ab6b0e")},
            {182,  new PantoneColor("146 U", "#9e7340")},
            {183,  new PantoneColor("147", "#725e26")},
            {184,  new PantoneColor("147 C", "#735b28")},
            {185,  new PantoneColor("147 U", "#776849")},
            {186,  new PantoneColor("148", "#ffd69b")},
            {187,  new PantoneColor("148 C", "#ffcb8a")},
            {188,  new PantoneColor("148 U", "#ffc586")},
            {189,  new PantoneColor("1485", "#ffb777")},
            {190,  new PantoneColor("1485 C", "#ffad5e")},
            {191,  new PantoneColor("1485 U", "#ffa660")},
            {192,  new PantoneColor("149", "#fccc93")},
            {193,  new PantoneColor("149 C", "#ffc27a")},
            {194,  new PantoneColor("149 U", "#ffb573")},
            {195,  new PantoneColor("1495", "#ff993f")},
            {196,  new PantoneColor("1495 C", "#ff8f12")},
            {197,  new PantoneColor("1495 U", "#ff934e")},
            {198,  new PantoneColor("150", "#fcad56")},
            {199,  new PantoneColor("150 C", "#ffb258")},
            {200,  new PantoneColor("150 U", "#ff9954")},
            {201,  new PantoneColor("1505", "#f47c00")},
            {202,  new PantoneColor("1505 C", "#ff6a00")},
            {203,  new PantoneColor("1505 U", "#ff8135")},
            {204,  new PantoneColor("151", "#f77f00")},
            {205,  new PantoneColor("151 C", "#ff8300")},
            {206,  new PantoneColor("151 U", "#ff873b")},
            {207,  new PantoneColor("152", "#dd7500")},
            {208,  new PantoneColor("152 C", "#e97200")},
            {209,  new PantoneColor("152 U", "#e3793d")},
            {210,  new PantoneColor("1525", "#b55400")},
            {211,  new PantoneColor("1525 C", "#bd4600")},
            {212,  new PantoneColor("1525 U", "#be6437")},
            {213,  new PantoneColor("153", "#bc6d0a")},
            {214,  new PantoneColor("153 C", "#c16a10")},
            {215,  new PantoneColor("153 U", "#ad6e41")},
            {216,  new PantoneColor("1535", "#8c4400")},
            {217,  new PantoneColor("1535 C", "#974508")},
            {218,  new PantoneColor("1535 U", "#976240")},
            {219,  new PantoneColor("154", "#995905")},
            {220,  new PantoneColor("154 C", "#9e5916")},
            {221,  new PantoneColor("154 U", "#926743")},
            {222,  new PantoneColor("1545", "#4c280f")},
            {223,  new PantoneColor("1545 C", "#683816")},
            {224,  new PantoneColor("1545 U", "#7b5e48")},
            {225,  new PantoneColor("155", "#f4dbaa")},
            {226,  new PantoneColor("155 C", "#f3d09e")},
            {227,  new PantoneColor("155 U", "#fac895")},
            {228,  new PantoneColor("1555", "#f9bf9e")},
            {229,  new PantoneColor("1555 C", "#ffb98d")},
            {230,  new PantoneColor("1555 U", "#ffc29c")},
            {231,  new PantoneColor("156", "#f2c68c")},
            {232,  new PantoneColor("156 C", "#f2bc7b")},
            {233,  new PantoneColor("156 U", "#fbb883")},
            {234,  new PantoneColor("1565", "#fca577")},
            {235,  new PantoneColor("1565 C", "#ffa167")},
            {236,  new PantoneColor("1565 U", "#ffaa81")},
            {237,  new PantoneColor("157", "#eda04f")},
            {238,  new PantoneColor("157 C", "#f19f53")},
            {239,  new PantoneColor("157 U", "#f69462")},
            {240,  new PantoneColor("1575", "#fc8744")},
            {241,  new PantoneColor("1575 C", "#ff7e2e")},
            {242,  new PantoneColor("1575 U", "#ff9562")},
            {243,  new PantoneColor("158", "#e87511")},
            {244,  new PantoneColor("158 C", "#ef7521")},
            {245,  new PantoneColor("158 U", "#f37d4a")},
            {246,  new PantoneColor("1585", "#f96b07")},
            {247,  new PantoneColor("1585 C", "#ff6b0b")},
            {248,  new PantoneColor("1585 U", "#ff844e")},
            {249,  new PantoneColor("159", "#c66005")},
            {250,  new PantoneColor("159 C", "#d25d12")},
            {251,  new PantoneColor("159 U", "#cd6f46")},
            {252,  new PantoneColor("1595", "#d15b05")},
            {253,  new PantoneColor("1595 C", "#dc5f13")},
            {254,  new PantoneColor("1595 U", "#d77045")},
            {255,  new PantoneColor("160", "#9e540a")},
            {256,  new PantoneColor("160 C", "#a5541a")},
            {257,  new PantoneColor("160 U", "#a06a45")},
            {258,  new PantoneColor("1605", "#a04f11")},
            {259,  new PantoneColor("1605 C", "#a95521")},
            {260,  new PantoneColor("1605 U", "#a86b4b")},
            {261,  new PantoneColor("161", "#633a11")},
            {262,  new PantoneColor("161 C", "#633c20")},
            {263,  new PantoneColor("161 U", "#776149")},
            {264,  new PantoneColor("1615", "#843f0f")},
            {265,  new PantoneColor("1615 C", "#8e471e")},
            {266,  new PantoneColor("1615 U", "#946449")},
            {267,  new PantoneColor("162", "#f9c6aa")},
            {268,  new PantoneColor("162 C", "#ffbe9e")},
            {269,  new PantoneColor("162 U", "#ffba98")},
            {270,  new PantoneColor("1625", "#f9a58c")},
            {271,  new PantoneColor("1625 C", "#ffa388")},
            {272,  new PantoneColor("1625 U", "#ffa88f")},
            {273,  new PantoneColor("163", "#fc9e70")},
            {274,  new PantoneColor("163 C", "#ff9d6b")},
            {275,  new PantoneColor("163 U", "#ff9b75")},
            {276,  new PantoneColor("1635", "#f98e6d")},
            {277,  new PantoneColor("1635 C", "#ff8d6a")},
            {278,  new PantoneColor("1635 U", "#ff967c")},
            {279,  new PantoneColor("164", "#fc7f3f")},
            {280,  new PantoneColor("164 C", "#ff7f3f")},
            {281,  new PantoneColor("164 U", "#ff855d")},
            {282,  new PantoneColor("1645", "#f97242")},
            {283,  new PantoneColor("1645 C", "#ff6b35")},
            {284,  new PantoneColor("1645 U", "#ff7f60")},
            {285,  new PantoneColor("165", "#f96302")},
            {286,  new PantoneColor("165 C", "#ff661b")},
            {287,  new PantoneColor("165 U", "#ff7546")},
            {288,  new PantoneColor("1655", "#f95602")},
            {289,  new PantoneColor("1655 C", "#ff4c00")},
            {290,  new PantoneColor("1655 U", "#ff704b")},
            {291,  new PantoneColor("166", "#dd5900")},
            {292,  new PantoneColor("166 C", "#e75200")},
            {293,  new PantoneColor("166 U", "#e5653e")},
            {294,  new PantoneColor("1665", "#dd4f05")},
            {295,  new PantoneColor("1665 C", "#e24301")},
            {296,  new PantoneColor("1665 U", "#e96847")},
            {297,  new PantoneColor("167", "#bc4f07")},
            {298,  new PantoneColor("167 C", "#c25219")},
            {299,  new PantoneColor("167 U", "#b76546")},
            {300,  new PantoneColor("1675", "#a53f0f")},
            {301,  new PantoneColor("1675 C", "#ad431c")},
            {302,  new PantoneColor("1675 U", "#ac6149")},
            {303,  new PantoneColor("168", "#6d3011")},
            {304,  new PantoneColor("168 C", "#75381b")},
            {305,  new PantoneColor("168 U", "#8b614b")},
            {306,  new PantoneColor("1685", "#843511")},
            {307,  new PantoneColor("1685 C", "#86391f")},
            {308,  new PantoneColor("1685 U", "#96604d")},
            {309,  new PantoneColor("169", "#f9baaa")},
            {310,  new PantoneColor("169 C", "#ffb4aa")},
            {311,  new PantoneColor("169 U", "#ffb7ac")},
            {312,  new PantoneColor("170", "#f98972")},
            {313,  new PantoneColor("170 C", "#ff8671")},
            {314,  new PantoneColor("170 U", "#ff8d7c")},
            {315,  new PantoneColor("171", "#f9603a")},
            {316,  new PantoneColor("171 C", "#ff5b34")},
            {317,  new PantoneColor("171 U", "#ff7762")},
            {318,  new PantoneColor("172", "#f74902")},
            {319,  new PantoneColor("172 C", "#ff4611")},
            {320,  new PantoneColor("172 U", "#ff674a")},
            {321,  new PantoneColor("173", "#d14414")},
            {322,  new PantoneColor("173 C", "#d3441c")},
            {323,  new PantoneColor("173 U", "#d06149")},
            {324,  new PantoneColor("174", "#933311")},
            {325,  new PantoneColor("174 C", "#99381f")},
            {326,  new PantoneColor("174 U", "#9d5b49")},
            {327,  new PantoneColor("175", "#6d3321")},
            {328,  new PantoneColor("175 C", "#6d3527")},
            {329,  new PantoneColor("175 U", "#7e584c")},
            {330,  new PantoneColor("176", "#f9afad")},
            {331,  new PantoneColor("176 C", "#ffb1b8")},
            {332,  new PantoneColor("1765", "#f99ea3")},
            {333,  new PantoneColor("1765 C", "#ffa4b3")},
            {334,  new PantoneColor("1765 U", "#ffa7b4")},
            {335,  new PantoneColor("1767", "#f9b2b7")},
            {336,  new PantoneColor("1767 C", "#ffafbf")},
            {337,  new PantoneColor("1767 U", "#ffbac8")},
            {338,  new PantoneColor("177", "#f9827f")},
            {339,  new PantoneColor("177 C", "#ff8188")},
            {340,  new PantoneColor("177 U", "#ff8c8f")},
            {341,  new PantoneColor("1775", "#f9848e")},
            {342,  new PantoneColor("1775 C", "#ff8e9e")},
            {343,  new PantoneColor("1775 U", "#ff8b97")},
            {344,  new PantoneColor("1777", "#fc6675")},
            {345,  new PantoneColor("1777 C", "#ff637d")},
            {346,  new PantoneColor("1777 U", "#ff808f")},
            {347,  new PantoneColor("178", "#f95e59")},
            {348,  new PantoneColor("178 C", "#ff5859")},
            {349,  new PantoneColor("178 U", "#ff7675")},
            {350,  new PantoneColor("1785", "#fc4f59")},
            {351,  new PantoneColor("1785 C", "#ff485b")},
            {352,  new PantoneColor("1785 U", "#ff6570")},
            {353,  new PantoneColor("1787", "#f43f4f")},
            {354,  new PantoneColor("1787 C", "#fb3448")},
            {355,  new PantoneColor("1787 U", "#ff636f")},
            {356,  new PantoneColor("1788", "#ef2b2d")},
            {357,  new PantoneColor("1788 C", "#f42434")},
            {358,  new PantoneColor("1788 U", "#fe5c61")},
            {359,  new PantoneColor("179", "#e23d28")},
            {360,  new PantoneColor("179 C", "#e53c2e")},
            {361,  new PantoneColor("179 U", "#e55f53")},
            {362,  new PantoneColor("1795", "#d62828")},
            {363,  new PantoneColor("1795 C", "#d8262e")},
            {364,  new PantoneColor("1795 U", "#dd5958")},
            {365,  new PantoneColor("1797", "#cc2d30")},
            {366,  new PantoneColor("1797 C", "#d03238")},
            {367,  new PantoneColor("1797 U", "#ce4e51")},
            {368,  new PantoneColor("180", "#c13828")},
            {369,  new PantoneColor("180 C", "#c33a32")},
            {370,  new PantoneColor("180 U", "#c06058")},
            {371,  new PantoneColor("1805", "#af2626")},
            {372,  new PantoneColor("1805 C", "#b3272d")},
            {373,  new PantoneColor("1805 U", "#b65957")},
            {374,  new PantoneColor("1807", "#a03033")},
            {375,  new PantoneColor("1807 C", "#a83338")},
            {376,  new PantoneColor("1807 U", "#a95051")},
            {377,  new PantoneColor("181", "#7c2d23")},
            {378,  new PantoneColor("181 C", "#84322c")},
            {379,  new PantoneColor("181 U", "#8b5951")},
            {380,  new PantoneColor("1810", "#7c211e")},
            {381,  new PantoneColor("1815 C", "#802528")},
            {382,  new PantoneColor("1815 U", "#905651")},
            {383,  new PantoneColor("1817", "#5b2d28")},
            {384,  new PantoneColor("1817 C", "#663233")},
            {385,  new PantoneColor("1817 U", "#7a5352")},
            {386,  new PantoneColor("182", "#f9bfc1")},
            {387,  new PantoneColor("182 C", "#febbca")},
            {388,  new PantoneColor("182 U", "#ffb8c8")},
            {389,  new PantoneColor("183", "#fc8c99")},
            {390,  new PantoneColor("183 C", "#ff9bb1")},
            {391,  new PantoneColor("183 U", "#ff8da2")},
            {392,  new PantoneColor("184", "#fc5e72")},
            {393,  new PantoneColor("184 C", "#fc5272")},
            {394,  new PantoneColor("184 U", "#ff6d82")},
            {395,  new PantoneColor("185", "#e8112d")},
            {396,  new PantoneColor("185 C", "#eb0028")},
            {397,  new PantoneColor("185 U", "#f7505f")},
            {398,  new PantoneColor("186", "#ce1126")},
            {399,  new PantoneColor("186 C", "#cf0a2c")},
            {400,  new PantoneColor("186 U", "#d6515d")},
            {401,  new PantoneColor("187", "#af1e2d")},
            {402,  new PantoneColor("187 C", "#ab162b")},
            {403,  new PantoneColor("187 U", "#b15359")},
            {404,  new PantoneColor("188", "#7c2128")},
            {405,  new PantoneColor("188 C", "#79232e")},
            {406,  new PantoneColor("188 U", "#8a5457")},
            {407,  new PantoneColor("189", "#ffa3b2")},
            {408,  new PantoneColor("189 C", "#fda3ba")},
            {409,  new PantoneColor("189 U", "#ffabc0")},
            {410,  new PantoneColor("1895", "#fcbfc9")},
            {411,  new PantoneColor("1895 C", "#f8b5cc")},
            {412,  new PantoneColor("1895 U", "#ffb3cc")},
            {413,  new PantoneColor("190", "#fc758e")},
            {414,  new PantoneColor("190 C", "#fb7497")},
            {415,  new PantoneColor("190 U", "#ff87a1")},
            {416,  new PantoneColor("1905", "#fc9bb2")},
            {417,  new PantoneColor("1905 C", "#fa9aba")},
            {418,  new PantoneColor("1905 U", "#ff9bb9")},
            {419,  new PantoneColor("191", "#f4476b")},
            {420,  new PantoneColor("191 C", "#f5416c")},
            {421,  new PantoneColor("191 U", "#fc6e88")},
            {422,  new PantoneColor("1915", "#f4547c")},
            {423,  new PantoneColor("1915 C", "#f54b7f")},
            {424,  new PantoneColor("1915 U", "#fb6f91")},
            {425,  new PantoneColor("192", "#e5053a")},
            {426,  new PantoneColor("192 C", "#ec0044")},
            {427,  new PantoneColor("192 U", "#f45269")},
            {428,  new PantoneColor("1925", "#e00747")},
            {429,  new PantoneColor("1925 C", "#e9004b")},
            {430,  new PantoneColor("1925 U", "#ee4e6c")},
            {431,  new PantoneColor("193", "#db828c")},
            {432,  new PantoneColor("193 C", "#c5093b")},
            {433,  new PantoneColor("193 U", "#c95163")},
            {434,  new PantoneColor("1935", "#c10538")},
            {435,  new PantoneColor("1935 C", "#cb003c")},
            {436,  new PantoneColor("1935 U", "#ce4b61")},
            {437,  new PantoneColor("194", "#992135")},
            {438,  new PantoneColor("194 C", "#a02741")},
            {439,  new PantoneColor("194 U", "#a65863")},
            {440,  new PantoneColor("1945", "#a80c35")},
            {441,  new PantoneColor("1945 C", "#ac063c")},
            {442,  new PantoneColor("1945 U", "#b35467")},
            {443,  new PantoneColor("195 C", "#7b2f3e")},
            {444,  new PantoneColor("195 U", "#895a61")},
            {445,  new PantoneColor("1955", "#931638")},
            {446,  new PantoneColor("1955 C", "#8f1336")},
            {447,  new PantoneColor("1955 U", "#9a5261")},
            {448,  new PantoneColor("196", "#f4c9c9")},
            {449,  new PantoneColor("196 C", "#efc6cd")},
            {450,  new PantoneColor("196 U", "#f7c2ca")},
            {451,  new PantoneColor("197", "#ef99a3")},
            {452,  new PantoneColor("197 C", "#ee9aac")},
            {453,  new PantoneColor("197 U", "#f59fb1")},
            {454,  new PantoneColor("198", "#772d35")},
            {455,  new PantoneColor("198 C", "#e74260")},
            {456,  new PantoneColor("198 U", "#ee687b")},
            {457,  new PantoneColor("199", "#d81c3f")},
            {458,  new PantoneColor("199 C", "#dc0031")},
            {459,  new PantoneColor("199 U", "#e34d5f")},
            {460,  new PantoneColor("200", "#c41e3a")},
            {461,  new PantoneColor("200 C", "#c2002f")},
            {462,  new PantoneColor("200 U", "#c24c5a")},
            {463,  new PantoneColor("2001 C", "#f7e49a")},
            {464,  new PantoneColor("2001 U", "#ffeb9f")},
            {465,  new PantoneColor("2002 C", "#f9e17d")},
            {466,  new PantoneColor("2002 U", "#ffe683")},
            {467,  new PantoneColor("2003 C", "#fae167")},
            {468,  new PantoneColor("2003 U", "#ffe774")},
            {469,  new PantoneColor("2004 C", "#fbdc7a")},
            {470,  new PantoneColor("2004 U", "#ffe17e")},
            {471,  new PantoneColor("2005 C", "#fed781")},
            {472,  new PantoneColor("2005 U", "#ffda82")},
            {473,  new PantoneColor("2006 C", "#ecbc4d")},
            {474,  new PantoneColor("2006 U", "#f2bf65")},
            {475,  new PantoneColor("2007 C", "#e1a423")},
            {476,  new PantoneColor("2007 U", "#e3a753")},
            {477,  new PantoneColor("2008 C", "#f2be70")},
            {478,  new PantoneColor("2008 U", "#fabc77")},
            {479,  new PantoneColor("2009 C", "#f2b562")},
            {480,  new PantoneColor("2009 U", "#fbaf6a")},
            {481,  new PantoneColor("201", "#a32638")},
            {482,  new PantoneColor("201 C", "#a31f34")},
            {483,  new PantoneColor("201 U", "#a4565e")},
            {484,  new PantoneColor("2010 C", "#ffad00")},
            {485,  new PantoneColor("2010 U", "#ffb300")},
            {486,  new PantoneColor("2011 C", "#f19933")},
            {487,  new PantoneColor("2011 U", "#f89756")},
            {488,  new PantoneColor("2012 C", "#f39500")},
            {489,  new PantoneColor("2012 U", "#fb9841")},
            {490,  new PantoneColor("2013 C", "#ff9800")},
            {491,  new PantoneColor("2013 U", "#ffa01f")},
            {492,  new PantoneColor("2014 C", "#bb7000")},
            {493,  new PantoneColor("2014 U", "#bd823d")},
            {494,  new PantoneColor("2015 C", "#f8cea6")},
            {495,  new PantoneColor("2015 U", "#ffd9b5")},
            {496,  new PantoneColor("2016 C", "#ffb771")},
            {497,  new PantoneColor("2016 U", "#ffc286")},
            {498,  new PantoneColor("2017 C", "#f8ad6a")},
            {499,  new PantoneColor("2017 U", "#ffb77f")},
            {500,  new PantoneColor("2018 C", "#ff7600")},
            {501,  new PantoneColor("2018 U", "#ff8a3d")},
            {502,  new PantoneColor("2019 C", "#da6c00")},
            {503,  new PantoneColor("2019 U", "#e08449")},
            {504,  new PantoneColor("202", "#8c2633")},
            {505,  new PantoneColor("202 C", "#8b2331")},
            {506,  new PantoneColor("202 U", "#92575d")},
            {507,  new PantoneColor("2020 C", "#c05400")},
            {508,  new PantoneColor("2020 U", "#c9713b")},
            {509,  new PantoneColor("2021 C", "#9f4812")},
            {510,  new PantoneColor("2021 U", "#a7633d")},
            {511,  new PantoneColor("2022 C", "#feaa8c")},
            {512,  new PantoneColor("2022 U", "#ffa98e")},
            {513,  new PantoneColor("2023 C", "#fd936e")},
            {514,  new PantoneColor("2023 U", "#ff9b7f")},
            {515,  new PantoneColor("2024 C", "#fd7b55")},
            {516,  new PantoneColor("2024 U", "#ff876e")},
            {517,  new PantoneColor("2025 C", "#ff8a39")},
            {518,  new PantoneColor("2025 U", "#ff955e")},
            {519,  new PantoneColor("2026 C", "#fa6238")},
            {520,  new PantoneColor("2026 U", "#ff755e")},
            {521,  new PantoneColor("2027 C", "#f3523e")},
            {522,  new PantoneColor("2027 U", "#fa6a62")},
            {523,  new PantoneColor("2028 C", "#f13000")},
            {524,  new PantoneColor("2028 U", "#f64f35")},
            {525,  new PantoneColor("2029 C", "#f7817d")},
            {526,  new PantoneColor("2029 U", "#fb8583")},
            {527,  new PantoneColor("203", "#f2afc1")},
            {528,  new PantoneColor("203 C", "#f0b2c9")},
            {529,  new PantoneColor("203 U", "#f8b0cb")},
            {530,  new PantoneColor("2030 C", "#e17973")},
            {531,  new PantoneColor("2030 U", "#ea8c89")},
            {532,  new PantoneColor("2031 C", "#da6764")},
            {533,  new PantoneColor("2031 U", "#e07b7b")},
            {534,  new PantoneColor("2032 C", "#d45856")},
            {535,  new PantoneColor("2032 U", "#d77170")},
            {536,  new PantoneColor("2033 C", "#ca4543")},
            {537,  new PantoneColor("2033 U", "#cd6866")},
            {538,  new PantoneColor("2034 C", "#ec3a3d")},
            {539,  new PantoneColor("2034 U", "#f25f62")},
            {540,  new PantoneColor("2035 C", "#dc001b")},
            {541,  new PantoneColor("2035 U", "#e43f41")},
            {542,  new PantoneColor("2036 C", "#f8bdd5")},
            {543,  new PantoneColor("2036 U", "#ffc3da")},
            {544,  new PantoneColor("2037 C", "#f695c5")},
            {545,  new PantoneColor("2037 U", "#ff9bca")},
            {546,  new PantoneColor("2038 C", "#f460a1")},
            {547,  new PantoneColor("2038 U", "#f772a5")},
            {548,  new PantoneColor("2039 C", "#ea3986")},
            {549,  new PantoneColor("2039 U", "#ef5b8e")},
            {550,  new PantoneColor("204", "#ed7a9e")},
            {551,  new PantoneColor("204 C", "#ec80a8")},
            {552,  new PantoneColor("204 U", "#f481a4")},
            {553,  new PantoneColor("2040 C", "#e1075a")},
            {554,  new PantoneColor("2040 U", "#e34068")},
            {555,  new PantoneColor("2041 C", "#a3234c")},
            {556,  new PantoneColor("2041 U", "#a44e63")},
            {557,  new PantoneColor("2042 C", "#72273b")},
            {558,  new PantoneColor("2042 U", "#7e4e56")},
            {559,  new PantoneColor("2043 C", "#e9c3d1")},
            {560,  new PantoneColor("2043 U", "#f0c0d1")},
            {561,  new PantoneColor("2044 C", "#e993b5")},
            {562,  new PantoneColor("2044 U", "#ec93b5")},
            {563,  new PantoneColor("2045 C", "#e0739e")},
            {564,  new PantoneColor("2045 U", "#e07b9e")},
            {565,  new PantoneColor("2046 C", "#d25788")},
            {566,  new PantoneColor("2046 U", "#cf6c8d")},
            {567,  new PantoneColor("2047 C", "#a7466e")},
            {568,  new PantoneColor("2047 U", "#a05f77")},
            {569,  new PantoneColor("2048 C", "#983a5f")},
            {570,  new PantoneColor("2048 U", "#965a6e")},
            {571,  new PantoneColor("2049 C", "#862d4a")},
            {572,  new PantoneColor("2049 U", "#8c5463")},
            {573,  new PantoneColor("205", "#e54c7c")},
            {574,  new PantoneColor("205 C", "#e7417a")},
            {575,  new PantoneColor("205 U", "#ea5f83")},
            {576,  new PantoneColor("2050 C", "#efd6e4")},
            {577,  new PantoneColor("2050 U", "#f7dbe8")},
            {578,  new PantoneColor("2051 C", "#ddc0cf")},
            {579,  new PantoneColor("2051 U", "#e5c7d4")},
            {580,  new PantoneColor("2052 C", "#cb9fb6")},
            {581,  new PantoneColor("2052 U", "#cfa5b9")},
            {582,  new PantoneColor("2053 C", "#b67e9d")},
            {583,  new PantoneColor("2053 U", "#ba8aa3")},
            {584,  new PantoneColor("2054 C", "#a06f8c")},
            {585,  new PantoneColor("2054 U", "#a47c92")},
            {586,  new PantoneColor("2055 C", "#925d7b")},
            {587,  new PantoneColor("2055 U", "#997187")},
            {588,  new PantoneColor("2056 C", "#814766")},
            {589,  new PantoneColor("2056 U", "#8a657a")},
            {590,  new PantoneColor("2057 C", "#d291b7")},
            {591,  new PantoneColor("2057 U", "#db9fbf")},
            {592,  new PantoneColor("2058 C", "#bb85a9")},
            {593,  new PantoneColor("2058 U", "#b285a4")},
            {594,  new PantoneColor("2059 C", "#ba7aa0")},
            {595,  new PantoneColor("2059 U", "#bb83a2")},
            {596,  new PantoneColor("206", "#d30547")},
            {597,  new PantoneColor("206 C", "#d60036")},
            {598,  new PantoneColor("206 U", "#de4164")},
            {599,  new PantoneColor("2060 C", "#cb6aa6")},
            {600,  new PantoneColor("2060 U", "#cc7aaa")},
            {601,  new PantoneColor("2061 C", "#b15188")},
            {602,  new PantoneColor("2061 U", "#b66f93")},
            {603,  new PantoneColor("2062 C", "#b7448c")},
            {604,  new PantoneColor("2062 U", "#b25f8e")},
            {605,  new PantoneColor("2063 C", "#a9307b")},
            {606,  new PantoneColor("2063 U", "#a3537f")},
            {607,  new PantoneColor("2064 C", "#e1a0d2")},
            {608,  new PantoneColor("2064 U", "#e394cb")},
            {609,  new PantoneColor("2065 C", "#dfa7dc")},
            {610,  new PantoneColor("2065 U", "#e1a0da")},
            {611,  new PantoneColor("2066 C", "#d38dd2")},
            {612,  new PantoneColor("2066 U", "#d68cd1")},
            {613,  new PantoneColor("2067 C", "#c269c1")},
            {614,  new PantoneColor("2067 U", "#c174bf")},
            {615,  new PantoneColor("2068 C", "#b44fb3")},
            {616,  new PantoneColor("2068 U", "#b364b2")},
            {617,  new PantoneColor("2069 C", "#a738a6")},
            {618,  new PantoneColor("2069 U", "#a85aa7")},
            {619,  new PantoneColor("207", "#baaa9e")},
            {620,  new PantoneColor("207 C", "#ab0032")},
            {621,  new PantoneColor("207 U", "#b34b63")},
            {622,  new PantoneColor("2070 C", "#911d92")},
            {623,  new PantoneColor("2070 U", "#964b95")},
            {624,  new PantoneColor("2071 C", "#c7b1dd")},
            {625,  new PantoneColor("2071 U", "#ccb3e1")},
            {626,  new PantoneColor("2072 C", "#b896d3")},
            {627,  new PantoneColor("2072 U", "#ba98d5")},
            {628,  new PantoneColor("2073 C", "#b094d2")},
            {629,  new PantoneColor("2073 U", "#ad95d3")},
            {630,  new PantoneColor("2074 C", "#9669bd")},
            {631,  new PantoneColor("2074 U", "#9776bb")},
            {632,  new PantoneColor("2075 C", "#8765bb")},
            {633,  new PantoneColor("2075 U", "#8c75ba")},
            {634,  new PantoneColor("2076 C", "#8558b3")},
            {635,  new PantoneColor("2076 U", "#8c6db2")},
            {636,  new PantoneColor("2077 C", "#6e3fa0")},
            {637,  new PantoneColor("2077 U", "#75579d")},
            {638,  new PantoneColor("2078 C", "#b59dbc")},
            {639,  new PantoneColor("2078 U", "#bea6c1")},
            {640,  new PantoneColor("2079 C", "#9c7da2")},
            {641,  new PantoneColor("2079 U", "#a58baa")},
            {642,  new PantoneColor("208", "#8e2344")},
            {643,  new PantoneColor("208 C", "#8b1c40")},
            {644,  new PantoneColor("208 U", "#935466")},
            {645,  new PantoneColor("2080 C", "#9872ab")},
            {646,  new PantoneColor("2080 U", "#987aa9")},
            {647,  new PantoneColor("2081 C", "#875d9c")},
            {648,  new PantoneColor("2081 U", "#8d6f9e")},
            {649,  new PantoneColor("2082 C", "#7a4d90")},
            {650,  new PantoneColor("2082 U", "#836894")},
            {651,  new PantoneColor("2083 C", "#965dc7")},
            {652,  new PantoneColor("2083 U", "#9c71c8")},
            {653,  new PantoneColor("2084 C", "#8037b1")},
            {654,  new PantoneColor("2084 U", "#8a5db2")},
            {655,  new PantoneColor("2085 C", "#dfcce6")},
            {656,  new PantoneColor("2085 U", "#e9d3ec")},
            {657,  new PantoneColor("2086 C", "#a08acb")},
            {658,  new PantoneColor("2086 U", "#a28fcc")},
            {659,  new PantoneColor("2087 C", "#9d7cd3")},
            {660,  new PantoneColor("2087 U", "#a085d7")},
            {661,  new PantoneColor("2088 C", "#835cc7")},
            {662,  new PantoneColor("2088 U", "#866cc5")},
            {663,  new PantoneColor("2089 C", "#7148bc")},
            {664,  new PantoneColor("2089 U", "#7a61b9")},
            {665,  new PantoneColor("209", "#75263d")},
            {666,  new PantoneColor("209 C", "#73243c")},
            {667,  new PantoneColor("209 U", "#835664")},
            {668,  new PantoneColor("2090 C", "#653ab6")},
            {669,  new PantoneColor("2090 U", "#755ab2")},
            {670,  new PantoneColor("2091 C", "#4b16a0")},
            {671,  new PantoneColor("2091 U", "#674da0")},
            {672,  new PantoneColor("2092 C", "#b9aad4")},
            {673,  new PantoneColor("2092 U", "#b7aad8")},
            {674,  new PantoneColor("2093 C", "#a597c1")},
            {675,  new PantoneColor("2093 U", "#a697bf")},
            {676,  new PantoneColor("2094 C", "#8e7eac")},
            {677,  new PantoneColor("2094 U", "#9284ac")},
            {678,  new PantoneColor("2095 C", "#7965b2")},
            {679,  new PantoneColor("2095 U", "#7f72af")},
            {680,  new PantoneColor("2096 C", "#664da1")},
            {681,  new PantoneColor("2096 U", "#776aa6")},
            {682,  new PantoneColor("2097 C", "#6045b9")},
            {683,  new PantoneColor("2097 U", "#6f5eb7")},
            {684,  new PantoneColor("2098 C", "#4527a9")},
            {685,  new PantoneColor("2098 U", "#6654a8")},
            {686,  new PantoneColor("2099 C", "#b1a2ca")},
            {687,  new PantoneColor("2099 U", "#aea0c9")},
            {688,  new PantoneColor("210", "#ffa0bf")},
            {689,  new PantoneColor("210 C", "#fd9fc8")},
            {690,  new PantoneColor("210 U", "#ffa2ca")},
            {691,  new PantoneColor("2100 C", "#9e8ec9")},
            {692,  new PantoneColor("2100 U", "#a495cc")},
            {693,  new PantoneColor("2101 C", "#8974d1")},
            {694,  new PantoneColor("2101 U", "#8c7cd0")},
            {695,  new PantoneColor("2102 C", "#6457b0")},
            {696,  new PantoneColor("2102 U", "#726bad")},
            {697,  new PantoneColor("2103 C", "#5848a5")},
            {698,  new PantoneColor("2103 U", "#6b63a4")},
            {699,  new PantoneColor("2104 C", "#483697")},
            {700,  new PantoneColor("2104 U", "#655c9b")},
            {701,  new PantoneColor("2105 C", "#36217b")},
            {702,  new PantoneColor("2105 U", "#615085")},
            {703,  new PantoneColor("2106 C", "#b0b4cd")},
            {704,  new PantoneColor("2106 U", "#b4b8d2")},
            {705,  new PantoneColor("2107 C", "#8f98b9")},
            {706,  new PantoneColor("2107 U", "#97a0be")},
            {707,  new PantoneColor("2108 C", "#777ea9")},
            {708,  new PantoneColor("2108 U", "#7f87a8")},
            {709,  new PantoneColor("2109 C", "#696b99")},
            {710,  new PantoneColor("2109 U", "#757b9c")},
            {711,  new PantoneColor("211", "#ff77a8")},
            {712,  new PantoneColor("211 C", "#fb7eb4")},
            {713,  new PantoneColor("211 U", "#ff85b4")},
            {714,  new PantoneColor("2110 C", "#5a5f8f")},
            {715,  new PantoneColor("2110 U", "#6e7494")},
            {716,  new PantoneColor("2111 C", "#444c7e")},
            {717,  new PantoneColor("2111 U", "#636989")},
            {718,  new PantoneColor("2112 C", "#322164")},
            {719,  new PantoneColor("2112 U", "#54476e")},
            {720,  new PantoneColor("2113 C", "#a4afe3")},
            {721,  new PantoneColor("2113 U", "#a7b1e7")},
            {722,  new PantoneColor("2114 C", "#838cc9")},
            {723,  new PantoneColor("2114 U", "#929cd1")},
            {724,  new PantoneColor("2115 C", "#6e78bd")},
            {725,  new PantoneColor("2115 U", "#838dc5")},
            {726,  new PantoneColor("2116 C", "#5e66b1")},
            {727,  new PantoneColor("2116 U", "#7a80ba")},
            {728,  new PantoneColor("2117 C", "#44489b")},
            {729,  new PantoneColor("2117 U", "#6568a1")},
            {730,  new PantoneColor("2118 C", "#323578")},
            {731,  new PantoneColor("2118 U", "#595a83")},
            {732,  new PantoneColor("2119 C", "#2a2d64")},
            {733,  new PantoneColor("2119 U", "#555577")},
            {734,  new PantoneColor("212", "#f94f8e")},
            {735,  new PantoneColor("212 C", "#f55096")},
            {736,  new PantoneColor("212 U", "#f96d9c")},
            {737,  new PantoneColor("2120 C", "#bdcaea")},
            {738,  new PantoneColor("2120 U", "#b3c3eb")},
            {739,  new PantoneColor("2121 C", "#8cabd8")},
            {740,  new PantoneColor("2121 U", "#8da9d9")},
            {741,  new PantoneColor("2122 C", "#9aade3")},
            {742,  new PantoneColor("2122 U", "#8da4e2")},
            {743,  new PantoneColor("2123 C", "#7892dd")},
            {744,  new PantoneColor("2123 U", "#738bda")},
            {745,  new PantoneColor("2124 C", "#6e7bd3")},
            {746,  new PantoneColor("2124 U", "#6b77cd")},
            {747,  new PantoneColor("2125 C", "#4f62c8")},
            {748,  new PantoneColor("2125 U", "#646cc3")},
            {749,  new PantoneColor("2126 C", "#273bb2")},
            {750,  new PantoneColor("2126 U", "#565baf")},
            {751,  new PantoneColor("2127 C", "#b6c8e1")},
            {752,  new PantoneColor("2127 U", "#b9cbe4")},
            {753,  new PantoneColor("2128 C", "#95b4e4")},
            {754,  new PantoneColor("2128 U", "#94b3e6")},
            {755,  new PantoneColor("2129 C", "#5a8cda")},
            {756,  new PantoneColor("2129 U", "#6a8edb")},
            {757,  new PantoneColor("213", "#ea0f6b")},
            {758,  new PantoneColor("213 C", "#ea1d75")},
            {759,  new PantoneColor("213 U", "#ee5483")},
            {760,  new PantoneColor("2130 C", "#5075d0")},
            {761,  new PantoneColor("2130 U", "#637ace")},
            {762,  new PantoneColor("2131 C", "#2e5bbe")},
            {763,  new PantoneColor("2131 U", "#586bba")},
            {764,  new PantoneColor("2132 C", "#0056c1")},
            {765,  new PantoneColor("2132 U", "#4e6dc3")},
            {766,  new PantoneColor("2133 C", "#1356a4")},
            {767,  new PantoneColor("2133 U", "#5470a9")},
            {768,  new PantoneColor("2134 C", "#90a4cf")},
            {769,  new PantoneColor("2134 U", "#9daed6")},
            {770,  new PantoneColor("2135 C", "#738bbf")},
            {771,  new PantoneColor("2135 U", "#8397c7")},
            {772,  new PantoneColor("2136 C", "#8293b8")},
            {773,  new PantoneColor("2136 U", "#8493b5")},
            {774,  new PantoneColor("2137 C", "#6c7eaa")},
            {775,  new PantoneColor("2137 U", "#7784a7")},
            {776,  new PantoneColor("2138 C", "#627592")},
            {777,  new PantoneColor("2138 U", "#6d798f")},
            {778,  new PantoneColor("2139 C", "#4c6896")},
            {779,  new PantoneColor("2139 U", "#627496")},
            {780,  new PantoneColor("214", "#cc0256")},
            {781,  new PantoneColor("214 C", "#d50f67")},
            {782,  new PantoneColor("214 U", "#d65079")},
            {783,  new PantoneColor("2140 C", "#375182")},
            {784,  new PantoneColor("2140 U", "#586689")},
            {785,  new PantoneColor("2141 C", "#88bde8")},
            {786,  new PantoneColor("2141 U", "#7fb8e9")},
            {787,  new PantoneColor("2142 C", "#7bace3")},
            {788,  new PantoneColor("2142 U", "#87b1e7")},
            {789,  new PantoneColor("2143 C", "#3485cc")},
            {790,  new PantoneColor("2143 U", "#5c8ccc")},
            {791,  new PantoneColor("2144 C", "#0065ba")},
            {792,  new PantoneColor("2144 U", "#4b79bc")},
            {793,  new PantoneColor("2145 C", "#004ca7")},
            {794,  new PantoneColor("2145 U", "#416bad")},
            {795,  new PantoneColor("2146 C", "#00348e")},
            {796,  new PantoneColor("2146 U", "#315193")},
            {797,  new PantoneColor("2147 C", "#002576")},
            {798,  new PantoneColor("2147 U", "#3f4e84")},
            {799,  new PantoneColor("2148 C", "#5e8fb3")},
            {800,  new PantoneColor("2148 U", "#7094b5")},
            {801,  new PantoneColor("2149 C", "#4b80a7")},
            {802,  new PantoneColor("2149 U", "#6488a9")},
            {803,  new PantoneColor("215", "#a50544")},
            {804,  new PantoneColor("215 C", "#af1556")},
            {805,  new PantoneColor("215 U", "#b1506f")},
            {806,  new PantoneColor("2150 C", "#32739d")},
            {807,  new PantoneColor("2150 U", "#5d7e9f")},
            {808,  new PantoneColor("2151 C", "#2169a2")},
            {809,  new PantoneColor("2151 U", "#52739e")},
            {810,  new PantoneColor("2152 C", "#156390")},
            {811,  new PantoneColor("2152 U", "#517292")},
            {812,  new PantoneColor("2153 C", "#00537d")},
            {813,  new PantoneColor("2153 U", "#4e6a87")},
            {814,  new PantoneColor("2154 C", "#00447f")},
            {815,  new PantoneColor("2154 U", "#435f86")},
            {816,  new PantoneColor("2155 C", "#9cb4cb")},
            {817,  new PantoneColor("2155 U", "#a2b9d0")},
            {818,  new PantoneColor("2156 C", "#8aa4c0")},
            {819,  new PantoneColor("2156 U", "#8ea8c4")},
            {820,  new PantoneColor("2157 C", "#7192b4")},
            {821,  new PantoneColor("2157 U", "#7c95b4")},
            {822,  new PantoneColor("2158 C", "#5881a6")},
            {823,  new PantoneColor("2158 U", "#6d89a8")},
            {824,  new PantoneColor("2159 C", "#4b759b")},
            {825,  new PantoneColor("2159 U", "#66809e")},
            {826,  new PantoneColor("216", "#7c1e3f")},
            {827,  new PantoneColor("216 C", "#802145")},
            {828,  new PantoneColor("216 U", "#8b5465")},
            {829,  new PantoneColor("2160 C", "#3d6891")},
            {830,  new PantoneColor("2160 U", "#5d7694")},
            {831,  new PantoneColor("2161 C", "#245681")},
            {832,  new PantoneColor("2161 U", "#4f6988")},
            {833,  new PantoneColor("2162 C", "#9da4b3")},
            {834,  new PantoneColor("2162 U", "#9ca3b2")},
            {835,  new PantoneColor("2163 C", "#849aaf")},
            {836,  new PantoneColor("2163 U", "#8ea0b2")},
            {837,  new PantoneColor("2164 C", "#7c92a7")},
            {838,  new PantoneColor("2164 U", "#8396a9")},
            {839,  new PantoneColor("2165 C", "#667f98")},
            {840,  new PantoneColor("2165 U", "#748699")},
            {841,  new PantoneColor("2166 C", "#54718a")},
            {842,  new PantoneColor("2166 U", "#6b7d90")},
            {843,  new PantoneColor("2167 C", "#4d6b86")},
            {844,  new PantoneColor("2167 U", "#647689")},
            {845,  new PantoneColor("2168 C", "#22495c")},
            {846,  new PantoneColor("2168 U", "#556774")},
            {847,  new PantoneColor("2169 C", "#7faed2")},
            {848,  new PantoneColor("2169 U", "#80afd3")},
            {849,  new PantoneColor("217", "#f4bfd1")},
            {850,  new PantoneColor("217 C", "#eebdda")},
            {851,  new PantoneColor("217 U", "#f6c0e1")},
            {852,  new PantoneColor("2170 C", "#5a9ac6")},
            {853,  new PantoneColor("2170 U", "#6094c0")},
            {854,  new PantoneColor("2171 C", "#3f9edf")},
            {855,  new PantoneColor("2171 U", "#4c95dc")},
            {856,  new PantoneColor("2172 C", "#0079d0")},
            {857,  new PantoneColor("2172 U", "#5284d3")},
            {858,  new PantoneColor("2173 C", "#0083d6")},
            {859,  new PantoneColor("2173 U", "#3c81d1")},
            {860,  new PantoneColor("2174 C", "#0075cf")},
            {861,  new PantoneColor("2174 U", "#3379cb")},
            {862,  new PantoneColor("2175 C", "#0068c7")},
            {863,  new PantoneColor("2175 U", "#2072c2")},
            {864,  new PantoneColor("2176 C", "#a4b7bf")},
            {865,  new PantoneColor("2176 U", "#b2c2cb")},
            {866,  new PantoneColor("2177 C", "#7d9eab")},
            {867,  new PantoneColor("2177 U", "#8da7b3")},
            {868,  new PantoneColor("2178 C", "#688d9c")},
            {869,  new PantoneColor("2178 U", "#7c97a3")},
            {870,  new PantoneColor("2179 C", "#4f7888")},
            {871,  new PantoneColor("2179 U", "#6d8896")},
            {872,  new PantoneColor("218", "#ed72aa")},
            {873,  new PantoneColor("218 C", "#eb6baf")},
            {874,  new PantoneColor("218 U", "#f482b8")},
            {875,  new PantoneColor("2180 C", "#3c6b7e")},
            {876,  new PantoneColor("2180 U", "#607a88")},
            {877,  new PantoneColor("2181 C", "#29596b")},
            {878,  new PantoneColor("2181 U", "#576f7c")},
            {879,  new PantoneColor("2182 C", "#12485b")},
            {880,  new PantoneColor("2182 U", "#526975")},
            {881,  new PantoneColor("2183 C", "#0090bd")},
            {882,  new PantoneColor("2183 U", "#3b91ba")},
            {883,  new PantoneColor("2184 C", "#0082d4")},
            {884,  new PantoneColor("2184 U", "#2d88d5")},
            {885,  new PantoneColor("2185 C", "#0074a6")},
            {886,  new PantoneColor("2185 U", "#357ea6")},
            {887,  new PantoneColor("2186 C", "#004787")},
            {888,  new PantoneColor("2186 U", "#225e8e")},
            {889,  new PantoneColor("2187 C", "#004477")},
            {890,  new PantoneColor("2187 U", "#375c7e")},
            {891,  new PantoneColor("2188 C", "#00406a")},
            {892,  new PantoneColor("2188 U", "#3a5b78")},
            {893,  new PantoneColor("2189 C", "#003248")},
            {894,  new PantoneColor("2189 U", "#435768")},
            {895,  new PantoneColor("219", "#e22882")},
            {896,  new PantoneColor("219 C", "#e11282")},
            {897,  new PantoneColor("219 U", "#e95b95")},
            {898,  new PantoneColor("2190 C", "#4fb5e5")},
            {899,  new PantoneColor("2190 U", "#4eb1e9")},
            {900,  new PantoneColor("2191 C", "#00a1e1")},
            {901,  new PantoneColor("2191 U", "#36a2e4")},
            {902,  new PantoneColor("2192 C", "#008edb")},
            {903,  new PantoneColor("2192 U", "#0095dd")},
            {904,  new PantoneColor("2193 C", "#008fdb")},
            {905,  new PantoneColor("2193 U", "#148cd9")},
            {906,  new PantoneColor("2194 C", "#0083d5")},
            {907,  new PantoneColor("2194 U", "#008bd6")},
            {908,  new PantoneColor("2195 C", "#0074ce")},
            {909,  new PantoneColor("2195 U", "#267dcd")},
            {910,  new PantoneColor("2196 C", "#0067b1")},
            {911,  new PantoneColor("2196 U", "#0165a0")},
            {912,  new PantoneColor("2197 C", "#6ed0e7")},
            {913,  new PantoneColor("2197 U", "#63d1ea")},
            {914,  new PantoneColor("2198 C", "#3ec7e4")},
            {915,  new PantoneColor("2198 U", "#30c7e7")},
            {916,  new PantoneColor("2199 C", "#00b8dd")},
            {917,  new PantoneColor("2199 U", "#00b8de")},
            {918,  new PantoneColor("220", "#aa004f")},
            {919,  new PantoneColor("220 C", "#ab004e")},
            {920,  new PantoneColor("220 U", "#b44a73")},
            {921,  new PantoneColor("2200 C", "#00a6c6")},
            {922,  new PantoneColor("2200 U", "#3ea8c7")},
            {923,  new PantoneColor("2201 C", "#00abd8")},
            {924,  new PantoneColor("2201 U", "#00acd7")},
            {925,  new PantoneColor("2202 C", "#00a2e0")},
            {926,  new PantoneColor("2202 U", "#00a8e4")},
            {927,  new PantoneColor("2203 C", "#0085ae")},
            {928,  new PantoneColor("2203 U", "#178bae")},
            {929,  new PantoneColor("2204 C", "#adcbd7")},
            {930,  new PantoneColor("2204 U", "#aaccd9")},
            {931,  new PantoneColor("2205 C", "#88b1c4")},
            {932,  new PantoneColor("2205 U", "#86b0c5")},
            {933,  new PantoneColor("2206 C", "#769db4")},
            {934,  new PantoneColor("2206 U", "#7ea1b7")},
            {935,  new PantoneColor("2207 C", "#6198b2")},
            {936,  new PantoneColor("2207 U", "#6f9bb3")},
            {937,  new PantoneColor("2208 C", "#5287a3")},
            {938,  new PantoneColor("2208 U", "#668da3")},
            {939,  new PantoneColor("2209 C", "#4684a0")},
            {940,  new PantoneColor("2209 U", "#648ca4")},
            {941,  new PantoneColor("221", "#930042")},
            {942,  new PantoneColor("221 C", "#970047")},
            {943,  new PantoneColor("221 U", "#a14c6c")},
            {944,  new PantoneColor("2210 C", "#084d71")},
            {945,  new PantoneColor("2210 U", "#47637c")},
            {946,  new PantoneColor("2211 C", "#6f98a3")},
            {947,  new PantoneColor("2211 U", "#7fa2ac")},
            {948,  new PantoneColor("2212 C", "#4e8391")},
            {949,  new PantoneColor("2212 U", "#688b97")},
            {950,  new PantoneColor("2213 C", "#2d6f78")},
            {951,  new PantoneColor("2213 U", "#5c7c82")},
            {952,  new PantoneColor("2214 C", "#2e6c79")},
            {953,  new PantoneColor("2214 U", "#5b7d87")},
            {954,  new PantoneColor("2215 C", "#2c5466")},
            {955,  new PantoneColor("2215 U", "#516874")},
            {956,  new PantoneColor("2216 C", "#2b4b58")},
            {957,  new PantoneColor("2216 U", "#4e616a")},
            {958,  new PantoneColor("2217 C", "#003841")},
            {959,  new PantoneColor("2217 U", "#43565e")},
            {960,  new PantoneColor("2218 C", "#6eaebd")},
            {961,  new PantoneColor("2218 U", "#75afbf")},
            {962,  new PantoneColor("2219 C", "#57a2b3")},
            {963,  new PantoneColor("2219 U", "#67a3b4")},
            {964,  new PantoneColor("222", "#70193d")},
            {965,  new PantoneColor("222 C", "#701c45")},
            {966,  new PantoneColor("222 U", "#85556a")},
            {967,  new PantoneColor("2220 C", "#4195a9")},
            {968,  new PantoneColor("2220 U", "#6199ab")},
            {969,  new PantoneColor("2221 C", "#278a9f")},
            {970,  new PantoneColor("2221 U", "#548fa0")},
            {971,  new PantoneColor("2222 C", "#0a8098")},
            {972,  new PantoneColor("2222 U", "#4e879b")},
            {973,  new PantoneColor("2223 C", "#00758e")},
            {974,  new PantoneColor("2223 U", "#447e92")},
            {975,  new PantoneColor("2224 C", "#006681")},
            {976,  new PantoneColor("2224 U", "#3c7386")},
            {977,  new PantoneColor("2225 C", "#70d3e1")},
            {978,  new PantoneColor("2225 U", "#69d6e5")},
            {979,  new PantoneColor("2226 C", "#2ec9da")},
            {980,  new PantoneColor("2226 U", "#39cbdd")},
            {981,  new PantoneColor("2227 C", "#52bcc9")},
            {982,  new PantoneColor("2227 U", "#5dbecd")},
            {983,  new PantoneColor("2228 C", "#00a2be")},
            {984,  new PantoneColor("2228 U", "#00a4be")},
            {985,  new PantoneColor("2229 C", "#0099b8")},
            {986,  new PantoneColor("2229 U", "#009bb6")},
            {987,  new PantoneColor("223", "#f993c4")},
            {988,  new PantoneColor("223 C", "#f294cd")},
            {989,  new PantoneColor("223 U", "#fca4d6")},
            {990,  new PantoneColor("2230 C", "#0089a1")},
            {991,  new PantoneColor("2230 U", "#1490a5")},
            {992,  new PantoneColor("2231 C", "#007993")},
            {993,  new PantoneColor("2231 U", "#008297")},
            {994,  new PantoneColor("2232 C", "#6daeb3")},
            {995,  new PantoneColor("2232 U", "#75afb5")},
            {996,  new PantoneColor("2233 C", "#54a5b0")},
            {997,  new PantoneColor("2233 U", "#63a4af")},
            {998,  new PantoneColor("2234 C", "#499da5")},
            {999,  new PantoneColor("2234 U", "#5c9ba2")},
            {1000,  new PantoneColor("2235 C", "#1c919d")},
            {1001,  new PantoneColor("2235 U", "#4e939d")},
            {1002,  new PantoneColor("2236 C", "#1e909a")},
            {1003,  new PantoneColor("2236 U", "#4e8e97")},
            {1004,  new PantoneColor("2237 U", "#4d8990")},
            {1005,  new PantoneColor("2238 C", "#006776")},
            {1006,  new PantoneColor("2238 U", "#30737d")},
            {1007,  new PantoneColor("2239 C", "#00ccb7")},
            {1008,  new PantoneColor("2239 U", "#00ceb6")},
            {1009,  new PantoneColor("224", "#f46baf")},
            {1010,  new PantoneColor("224 C", "#ef6eba")},
            {1011,  new PantoneColor("224 U", "#f987c6")},
            {1012,  new PantoneColor("2240 C", "#00bea1")},
            {1013,  new PantoneColor("2240 U", "#00bfa4")},
            {1014,  new PantoneColor("2241 C", "#53a092")},
            {1015,  new PantoneColor("2241 U", "#63a094")},
            {1016,  new PantoneColor("2242 C", "#00a077")},
            {1017,  new PantoneColor("2242 U", "#00a081")},
            {1018,  new PantoneColor("2243 C", "#00927b")},
            {1019,  new PantoneColor("2243 U", "#3c9383")},
            {1020,  new PantoneColor("2244 C", "#087e6d")},
            {1021,  new PantoneColor("2244 U", "#4d857b")},
            {1022,  new PantoneColor("2245 C", "#008356")},
            {1023,  new PantoneColor("2245 U", "#008a6c")},
            {1024,  new PantoneColor("2246 C", "#a7d2b9")},
            {1025,  new PantoneColor("2246 U", "#a5d6bc")},
            {1026,  new PantoneColor("2247 C", "#74bf99")},
            {1027,  new PantoneColor("2247 U", "#7bc4a0")},
            {1028,  new PantoneColor("2248 C", "#6cb691")},
            {1029,  new PantoneColor("2248 U", "#78ba98")},
            {1030,  new PantoneColor("2249 C", "#53a97f")},
            {1031,  new PantoneColor("2249 U", "#67aa86")},
            {1032,  new PantoneColor("225", "#ed2893")},
            {1033,  new PantoneColor("225 C", "#e51992")},
            {1034,  new PantoneColor("225 U", "#ef60a4")},
            {1035,  new PantoneColor("2250 C", "#00b073")},
            {1036,  new PantoneColor("2250 U", "#21ae7b")},
            {1037,  new PantoneColor("2251 C", "#00aa71")},
            {1038,  new PantoneColor("2251 U", "#00a778")},
            {1039,  new PantoneColor("2252 C", "#00a54d")},
            {1040,  new PantoneColor("2252 U", "#00a763")},
            {1041,  new PantoneColor("2253 C", "#bae8ca")},
            {1042,  new PantoneColor("2253 U", "#bfefce")},
            {1043,  new PantoneColor("2254 C", "#acddb2")},
            {1044,  new PantoneColor("2254 U", "#ace2b4")},
            {1045,  new PantoneColor("2255 C", "#85d095")},
            {1046,  new PantoneColor("2255 U", "#86d59b")},
            {1047,  new PantoneColor("2256 C", "#53c072")},
            {1048,  new PantoneColor("2256 U", "#5dc380")},
            {1049,  new PantoneColor("2257 C", "#00ab51")},
            {1050,  new PantoneColor("2257 U", "#34aa68")},
            {1051,  new PantoneColor("2258 C", "#008424")},
            {1052,  new PantoneColor("2258 U", "#418f53")},
            {1053,  new PantoneColor("2259 C", "#007022")},
            {1054,  new PantoneColor("2259 U", "#458151")},
            {1055,  new PantoneColor("226", "#d60270")},
            {1056,  new PantoneColor("226 C", "#d7006d")},
            {1057,  new PantoneColor("226 U", "#e14486")},
            {1058,  new PantoneColor("2260 C", "#b2cfad")},
            {1059,  new PantoneColor("2260 U", "#c0dabb")},
            {1060,  new PantoneColor("2261 C", "#96ba91")},
            {1061,  new PantoneColor("2261 U", "#93b78e")},
            {1062,  new PantoneColor("2262 C", "#88ac89")},
            {1063,  new PantoneColor("2262 U", "#8bac8c")},
            {1064,  new PantoneColor("2263 C", "#6f946b")},
            {1065,  new PantoneColor("2263 U", "#7c9a7b")},
            {1066,  new PantoneColor("2264 C", "#669460")},
            {1067,  new PantoneColor("2264 U", "#71966f")},
            {1068,  new PantoneColor("2265 C", "#587d50")},
            {1069,  new PantoneColor("2265 U", "#738e70")},
            {1070,  new PantoneColor("2266 C", "#2d5423")},
            {1071,  new PantoneColor("2266 U", "#577754")},
            {1072,  new PantoneColor("2267 C", "#96de99")},
            {1073,  new PantoneColor("2267 U", "#98e69f")},
            {1074,  new PantoneColor("2268 C", "#72d77d")},
            {1075,  new PantoneColor("2268 U", "#6edb84")},
            {1076,  new PantoneColor("2269 C", "#78ca6d")},
            {1077,  new PantoneColor("2269 U", "#6bc774")},
            {1078,  new PantoneColor("227", "#ad005b")},
            {1079,  new PantoneColor("227 C", "#b00060")},
            {1080,  new PantoneColor("227 U", "#b24776")},
            {1081,  new PantoneColor("2270 C", "#17c54e")},
            {1082,  new PantoneColor("2270 U", "#3ac867")},
            {1083,  new PantoneColor("2271 C", "#00b832")},
            {1084,  new PantoneColor("2271 U", "#12ba58")},
            {1085,  new PantoneColor("2272 C", "#00981a")},
            {1086,  new PantoneColor("2272 U", "#3ba047")},
            {1087,  new PantoneColor("2273 C", "#227026")},
            {1088,  new PantoneColor("2273 U", "#4e7c4e")},
            {1089,  new PantoneColor("2274 C", "#d0d9b1")},
            {1090,  new PantoneColor("2274 U", "#d6dfb5")},
            {1091,  new PantoneColor("2275 C", "#c3da95")},
            {1092,  new PantoneColor("2275 U", "#c7e09a")},
            {1093,  new PantoneColor("2276 C", "#88a650")},
            {1094,  new PantoneColor("2276 U", "#8aa667")},
            {1095,  new PantoneColor("2277 C", "#52941d")},
            {1096,  new PantoneColor("2277 U", "#649847")},
            {1097,  new PantoneColor("2278 C", "#4b7f1e")},
            {1098,  new PantoneColor("2278 U", "#628b4a")},
            {1099,  new PantoneColor("2279 C", "#5c7d2a")},
            {1100,  new PantoneColor("2279 U", "#6d8453")},
            {1101,  new PantoneColor("228", "#8c004c")},
            {1102,  new PantoneColor("228 C", "#8d0b56")},
            {1103,  new PantoneColor("228 U", "#8f4d6d")},
            {1104,  new PantoneColor("2280 C", "#47691d")},
            {1105,  new PantoneColor("2280 U", "#627a4b")},
            {1106,  new PantoneColor("2281 C", "#d8e798")},
            {1107,  new PantoneColor("2281 U", "#dbec99")},
            {1108,  new PantoneColor("2282 C", "#c6e895")},
            {1109,  new PantoneColor("2282 U", "#c7ed97")},
            {1110,  new PantoneColor("2283 C", "#a3df65")},
            {1111,  new PantoneColor("2283 U", "#a6e474")},
            {1112,  new PantoneColor("2284 C", "#b0d37d")},
            {1113,  new PantoneColor("2284 U", "#b0d683")},
            {1114,  new PantoneColor("2285 C", "#8fd84a")},
            {1115,  new PantoneColor("2285 U", "#8fdd63")},
            {1116,  new PantoneColor("2286 C", "#74ca00")},
            {1117,  new PantoneColor("2286 U", "#7bd145")},
            {1118,  new PantoneColor("2287 C", "#54c400")},
            {1119,  new PantoneColor("2287 U", "#5cc647")},
            {1120,  new PantoneColor("2288 C", "#c8e179")},
            {1121,  new PantoneColor("2288 U", "#c9e681")},
            {1122,  new PantoneColor("2289 C", "#c5d779")},
            {1123,  new PantoneColor("2289 U", "#c6dc84")},
            {1124,  new PantoneColor("229", "#6d213f")},
            {1125,  new PantoneColor("229 C", "#692044")},
            {1126,  new PantoneColor("229 U", "#7b5365")},
            {1127,  new PantoneColor("2290 C", "#a7d91d")},
            {1128,  new PantoneColor("2290 U", "#aae053")},
            {1129,  new PantoneColor("2291 C", "#a4d300")},
            {1130,  new PantoneColor("2291 U", "#a2d834")},
            {1131,  new PantoneColor("2292 C", "#91c712")},
            {1132,  new PantoneColor("2292 U", "#89c648")},
            {1133,  new PantoneColor("2293 C", "#86c300")},
            {1134,  new PantoneColor("2293 U", "#8acb23")},
            {1135,  new PantoneColor("2294 C", "#74a800")},
            {1136,  new PantoneColor("2294 U", "#7eb03b")},
            {1137,  new PantoneColor("2295 C", "#e1ea89")},
            {1138,  new PantoneColor("2295 U", "#e5f08c")},
            {1139,  new PantoneColor("2296 C", "#d5e664")},
            {1140,  new PantoneColor("2296 U", "#d6ec70")},
            {1141,  new PantoneColor("2297 C", "#bcde16")},
            {1142,  new PantoneColor("2297 U", "#bfe44d")},
            {1143,  new PantoneColor("2298 C", "#b6d955")},
            {1144,  new PantoneColor("2298 U", "#afdb66")},
            {1145,  new PantoneColor("2299 C", "#a2d033")},
            {1146,  new PantoneColor("2299 U", "#9bd154")},
            {1147,  new PantoneColor("230", "#ffa0cc")},
            {1148,  new PantoneColor("230 C", "#f7a6d6")},
            {1149,  new PantoneColor("230 U", "#ffb2de")},
            {1150,  new PantoneColor("2300 C", "#a8c140")},
            {1151,  new PantoneColor("2300 U", "#abc663")},
            {1152,  new PantoneColor("2301 C", "#8dac14")},
            {1153,  new PantoneColor("2301 U", "#8fad4d")},
            {1154,  new PantoneColor("2302 C", "#aeb762")},
            {1155,  new PantoneColor("2302 U", "#a9b36e")},
            {1156,  new PantoneColor("2303 C", "#9fb156")},
            {1157,  new PantoneColor("2303 U", "#9eb16d")},
            {1158,  new PantoneColor("2304 C", "#a0aa4d")},
            {1159,  new PantoneColor("2304 U", "#9da763")},
            {1160,  new PantoneColor("2305 C", "#9da600")},
            {1161,  new PantoneColor("2305 U", "#9ca647")},
            {1162,  new PantoneColor("2306 C", "#7e8a24")},
            {1163,  new PantoneColor("2306 U", "#818c50")},
            {1164,  new PantoneColor("2307 C", "#676e11")},
            {1165,  new PantoneColor("2307 U", "#767e40")},
            {1166,  new PantoneColor("2308 C", "#59561a")},
            {1167,  new PantoneColor("2308 U", "#6a6941")},
            {1168,  new PantoneColor("2309 C", "#e7cdb5")},
            {1169,  new PantoneColor("2309 U", "#eccfb3")},
            {1170,  new PantoneColor("231", "#fc70ba")},
            {1171,  new PantoneColor("231 C", "#f677c4")},
            {1172,  new PantoneColor("231 U", "#fc85c8")},
            {1173,  new PantoneColor("2310 C", "#d8bfa7")},
            {1174,  new PantoneColor("2310 U", "#ddc0a7")},
            {1175,  new PantoneColor("2311 C", "#cca784")},
            {1176,  new PantoneColor("2311 U", "#cca88a")},
            {1177,  new PantoneColor("2312 C", "#b79a80")},
            {1178,  new PantoneColor("2312 U", "#baa08b")},
            {1179,  new PantoneColor("2313 C", "#c39365")},
            {1180,  new PantoneColor("2313 U", "#c19676")},
            {1181,  new PantoneColor("2314 C", "#ac7743")},
            {1182,  new PantoneColor("2314 U", "#a98062")},
            {1183,  new PantoneColor("2315 C", "#93480d")},
            {1184,  new PantoneColor("2315 U", "#96623e")},
            {1185,  new PantoneColor("2316 C", "#bd9979")},
            {1186,  new PantoneColor("2316 U", "#c09f85")},
            {1187,  new PantoneColor("2317 C", "#b4865c")},
            {1188,  new PantoneColor("2317 U", "#b18c70")},
            {1189,  new PantoneColor("2318 C", "#a47447")},
            {1190,  new PantoneColor("2318 U", "#a17d63")},
            {1191,  new PantoneColor("2319 C", "#8d5b2f")},
            {1192,  new PantoneColor("2319 U", "#8d6d55")},
            {1193,  new PantoneColor("232", "#f43fa5")},
            {1194,  new PantoneColor("232 C", "#ef3fa9")},
            {1195,  new PantoneColor("232 U", "#f56ab4")},
            {1196,  new PantoneColor("2320 C", "#714621")},
            {1197,  new PantoneColor("2320 U", "#795c46")},
            {1198,  new PantoneColor("2321 C", "#6f5036")},
            {1199,  new PantoneColor("2321 U", "#7a695b")},
            {1200,  new PantoneColor("2322 C", "#4d3423")},
            {1201,  new PantoneColor("2322 U", "#625140")},
            {1202,  new PantoneColor("2323 C", "#b7b098")},
            {1203,  new PantoneColor("2323 U", "#c5bfaa")},
            {1204,  new PantoneColor("2324 C", "#b2a282")},
            {1205,  new PantoneColor("2324 U", "#ada189")},
            {1206,  new PantoneColor("2325 C", "#9f9073")},
            {1207,  new PantoneColor("2325 U", "#a09580")},
            {1208,  new PantoneColor("2326 C", "#8b7c5e")},
            {1209,  new PantoneColor("2326 U", "#958b78")},
            {1210,  new PantoneColor("2327 C", "#837857")},
            {1211,  new PantoneColor("2327 U", "#908875")},
            {1212,  new PantoneColor("2328 C", "#786747")},
            {1213,  new PantoneColor("2328 U", "#807766")},
            {1214,  new PantoneColor("2329 C", "#69583b")},
            {1215,  new PantoneColor("2329 U", "#766e61")},
            {1216,  new PantoneColor("233", "#ce007c")},
            {1217,  new PantoneColor("233 C", "#cc007a")},
            {1218,  new PantoneColor("233 U", "#cc4585")},
            {1219,  new PantoneColor("2330 C", "#cfccc8")},
            {1220,  new PantoneColor("2331 C", "#aca7a3")},
            {1221,  new PantoneColor("2331 U", "#b0aba9")},
            {1222,  new PantoneColor("2332 C", "#8b8985")},
            {1223,  new PantoneColor("2332 U", "#8b8986")},
            {1224,  new PantoneColor("2333 C", "#716c69")},
            {1225,  new PantoneColor("2333 U", "#757473")},
            {1226,  new PantoneColor("2334 C", "#6d6361")},
            {1227,  new PantoneColor("2334 U", "#706c6c")},
            {1228,  new PantoneColor("2335 C", "#5e4e46")},
            {1229,  new PantoneColor("2335 U", "#706964")},
            {1230,  new PantoneColor("2336 C", "#4e4946")},
            {1231,  new PantoneColor("2336 U", "#666565")},
            {1232,  new PantoneColor("2337 C", "#fac0b8")},
            {1233,  new PantoneColor("2337 U", "#ffb6ad")},
            {1234,  new PantoneColor("2338 C", "#e0a39d")},
            {1235,  new PantoneColor("2338 U", "#dc9b95")},
            {1236,  new PantoneColor("2339 C", "#f29390")},
            {1237,  new PantoneColor("2339 U", "#f5908e")},
            {1238,  new PantoneColor("234", "#aa0066")},
            {1239,  new PantoneColor("234 C", "#a60063")},
            {1240,  new PantoneColor("234 U", "#ac4c7b")},
            {1241,  new PantoneColor("2340 C", "#d26e76")},
            {1242,  new PantoneColor("2340 U", "#cc797d")},
            {1243,  new PantoneColor("2341 C", "#b96b6c")},
            {1244,  new PantoneColor("2341 U", "#ae7475")},
            {1245,  new PantoneColor("2342 C", "#ba5963")},
            {1246,  new PantoneColor("2342 U", "#b16c73")},
            {1247,  new PantoneColor("2343 C", "#aa5564")},
            {1248,  new PantoneColor("2343 U", "#a86c75")},
            {1249,  new PantoneColor("2344 C", "#f3806e")},
            {1250,  new PantoneColor("2344 U", "#f08576")},
            {1251,  new PantoneColor("2345 C", "#ff6e67")},
            {1252,  new PantoneColor("2345 U", "#ff7d74")},
            {1253,  new PantoneColor("2346 C", "#ff5967")},
            {1254,  new PantoneColor("2346 U", "#ff7075")},
            {1255,  new PantoneColor("2347 C", "#e80000")},
            {1256,  new PantoneColor("2347 U", "#ed4336")},
            {1257,  new PantoneColor("2348 C", "#ea534d")},
            {1258,  new PantoneColor("2348 U", "#e1615c")},
            {1259,  new PantoneColor("2349 C", "#ce3402")},
            {1260,  new PantoneColor("2349 U", "#c44d36")},
            {1261,  new PantoneColor("235", "#8e0554")},
            {1262,  new PantoneColor("235 C", "#880d53")},
            {1263,  new PantoneColor("235 U", "#924e70")},
            {1264,  new PantoneColor("2350 C", "#b5201b")},
            {1265,  new PantoneColor("2350 U", "#a1463d")},
            {1266,  new PantoneColor("2351 C", "#bf79b2")},
            {1267,  new PantoneColor("2351 U", "#bd81b1")},
            {1268,  new PantoneColor("2352 C", "#b764a6")},
            {1269,  new PantoneColor("2352 U", "#b471a3")},
            {1270,  new PantoneColor("2353 C", "#c44ca5")},
            {1271,  new PantoneColor("2353 U", "#b85997")},
            {1272,  new PantoneColor("2354 C", "#944d8a")},
            {1273,  new PantoneColor("2354 U", "#90638b")},
            {1274,  new PantoneColor("2355 C", "#8b0079")},
            {1275,  new PantoneColor("2355 U", "#86467a")},
            {1276,  new PantoneColor("2356 C", "#750060")},
            {1277,  new PantoneColor("2356 U", "#7e3f6f")},
            {1278,  new PantoneColor("2357 C", "#641143")},
            {1279,  new PantoneColor("2357 U", "#6e435a")},
            {1280,  new PantoneColor("2358 C", "#ada3ae")},
            {1281,  new PantoneColor("2358 U", "#a499a5")},
            {1282,  new PantoneColor("2359 C", "#7e7283")},
            {1283,  new PantoneColor("2359 U", "#807785")},
            {1284,  new PantoneColor("236", "#f9afd3")},
            {1285,  new PantoneColor("236 C", "#f4a7dc")},
            {1286,  new PantoneColor("236 U", "#faa6dd")},
            {1287,  new PantoneColor("2360 C", "#7a788e")},
            {1288,  new PantoneColor("2360 U", "#7f7c8d")},
            {1289,  new PantoneColor("2361 C", "#6f6f8b")},
            {1290,  new PantoneColor("2361 U", "#75758c")},
            {1291,  new PantoneColor("2362 C", "#6d6980")},
            {1292,  new PantoneColor("2362 U", "#787585")},
            {1293,  new PantoneColor("2363 C", "#5f5c75")},
            {1294,  new PantoneColor("2363 U", "#6f6c7c")},
            {1295,  new PantoneColor("2364 C", "#67586d")},
            {1296,  new PantoneColor("2364 U", "#726976")},
            {1297,  new PantoneColor("2365", "#f7c4d8")},
            {1298,  new PantoneColor("2365 C", "#f2b9df")},
            {1299,  new PantoneColor("2365 U", "#f9bee6")},
            {1300,  new PantoneColor("2366 C", "#676ccd")},
            {1301,  new PantoneColor("2366 U", "#6f71c7")},
            {1302,  new PantoneColor("2367 C", "#4d4bb0")},
            {1303,  new PantoneColor("2367 U", "#6663ad")},
            {1304,  new PantoneColor("2368 C", "#4a49bc")},
            {1305,  new PantoneColor("2368 U", "#6160b7")},
            {1306,  new PantoneColor("2369 C", "#3640b5")},
            {1307,  new PantoneColor("2369 U", "#5b5cb0")},
            {1308,  new PantoneColor("237", "#f484c4")},
            {1309,  new PantoneColor("237 C", "#f185ce")},
            {1310,  new PantoneColor("237 U", "#f58dcf")},
            {1311,  new PantoneColor("2370 C", "#2b2b93")},
            {1312,  new PantoneColor("2370 U", "#5d599b")},
            {1313,  new PantoneColor("2371 C", "#300b8c")},
            {1314,  new PantoneColor("2371 U", "#58468c")},
            {1315,  new PantoneColor("2372 C", "#251e77")},
            {1316,  new PantoneColor("2372 U", "#524d7f")},
            {1317,  new PantoneColor("2373 C", "#7181a0")},
            {1318,  new PantoneColor("2373 U", "#78829b")},
            {1319,  new PantoneColor("2374 C", "#4d5e80")},
            {1320,  new PantoneColor("2374 U", "#5e687f")},
            {1321,  new PantoneColor("2375", "#ea6bbf")},
            {1322,  new PantoneColor("2375 C", "#e677cb")},
            {1323,  new PantoneColor("2375 U", "#ed88d1")},
            {1324,  new PantoneColor("2376 C", "#4d5a72")},
            {1325,  new PantoneColor("2376 U", "#636c7d")},
            {1326,  new PantoneColor("2377 C", "#305271")},
            {1327,  new PantoneColor("2377 U", "#55687c")},
            {1328,  new PantoneColor("2378 C", "#374767")},
            {1329,  new PantoneColor("2378 U", "#555d71")},
            {1330,  new PantoneColor("2379 C", "#3b4358")},
            {1331,  new PantoneColor("2379 U", "#565a66")},
            {1332,  new PantoneColor("238", "#ed4faf")},
            {1333,  new PantoneColor("238 C", "#ea5dbd")},
            {1334,  new PantoneColor("238 U", "#ed72bf")},
            {1335,  new PantoneColor("2380 C", "#273248")},
            {1336,  new PantoneColor("2380 U", "#525664")},
            {1337,  new PantoneColor("2381 C", "#5992db")},
            {1338,  new PantoneColor("2381 U", "#618dd8")},
            {1339,  new PantoneColor("2382 C", "#0088d8")},
            {1340,  new PantoneColor("2382 U", "#3d82d2")},
            {1341,  new PantoneColor("2383 C", "#2173ad")},
            {1342,  new PantoneColor("2383 U", "#4a72a2")},
            {1343,  new PantoneColor("2384 C", "#0060a1")},
            {1344,  new PantoneColor("2384 U", "#3b6796")},
            {1345,  new PantoneColor("2385", "#db28a5")},
            {1346,  new PantoneColor("2385 C", "#d939b2")},
            {1347,  new PantoneColor("2385 U", "#e56fc0")},
            {1348,  new PantoneColor("2386 C", "#2768c3")},
            {1349,  new PantoneColor("2386 U", "#546fbd")},
            {1350,  new PantoneColor("2387 C", "#0061c8")},
            {1351,  new PantoneColor("2387 U", "#4767bd")},
            {1352,  new PantoneColor("2388 C", "#004fb5")},
            {1353,  new PantoneColor("2388 U", "#3c5ea8")},
            {1354,  new PantoneColor("2389 C", "#449ec9")},
            {1355,  new PantoneColor("2389 U", "#5b9cc6")},
            {1356,  new PantoneColor("239", "#e0219e")},
            {1357,  new PantoneColor("239 C", "#e03eae")},
            {1358,  new PantoneColor("239 U", "#e055a7")},
            {1359,  new PantoneColor("2390 C", "#007bab")},
            {1360,  new PantoneColor("2390 U", "#4e83aa")},
            {1361,  new PantoneColor("2391 C", "#0080a5")},
            {1362,  new PantoneColor("2391 U", "#4683a1")},
            {1363,  new PantoneColor("2392 C", "#096785")},
            {1364,  new PantoneColor("2392 U", "#587b90")},
            {1365,  new PantoneColor("2393 C", "#0090cb")},
            {1366,  new PantoneColor("2393 U", "#0095cc")},
            {1367,  new PantoneColor("2394 C", "#0089ce")},
            {1368,  new PantoneColor("2394 U", "#008fce")},
            {1369,  new PantoneColor("2395", "#c4008c")},
            {1370,  new PantoneColor("2395 C", "#cf009e")},
            {1371,  new PantoneColor("2395 U", "#d956ac")},
            {1372,  new PantoneColor("2396 C", "#0096b2")},
            {1373,  new PantoneColor("2396 U", "#0093ab")},
            {1374,  new PantoneColor("2397 C", "#00b4bd")},
            {1375,  new PantoneColor("2397 U", "#00b1ba")},
            {1376,  new PantoneColor("2398 C", "#00b8b3")},
            {1377,  new PantoneColor("2398 U", "#2cbbb6")},
            {1378,  new PantoneColor("2399 C", "#00a8a2")},
            {1379,  new PantoneColor("2399 U", "#00ada8")},
            {1380,  new PantoneColor("240", "#c40f89")},
            {1381,  new PantoneColor("240 C", "#cb2b99")},
            {1382,  new PantoneColor("240 U", "#c55597")},
            {1383,  new PantoneColor("2400 C", "#00ad97")},
            {1384,  new PantoneColor("2400 U", "#00ae9a")},
            {1385,  new PantoneColor("2401 C", "#28a598")},
            {1386,  new PantoneColor("2401 U", "#52a69b")},
            {1387,  new PantoneColor("2402 C", "#009a87")},
            {1388,  new PantoneColor("2402 U", "#009e8d")},
            {1389,  new PantoneColor("2403 C", "#00867b")},
            {1390,  new PantoneColor("2403 U", "#008d85")},
            {1391,  new PantoneColor("2404 C", "#a4b79c")},
            {1392,  new PantoneColor("2404 U", "#9fb39a")},
            {1393,  new PantoneColor("2405", "#a8007a")},
            {1394,  new PantoneColor("2405 C", "#b5008c")},
            {1395,  new PantoneColor("2405 U", "#be569c")},
            {1396,  new PantoneColor("2406 C", "#809c87")},
            {1397,  new PantoneColor("2406 U", "#869f8f")},
            {1398,  new PantoneColor("2407 C", "#698b72")},
            {1399,  new PantoneColor("2407 U", "#779080")},
            {1400,  new PantoneColor("2408 C", "#477956")},
            {1401,  new PantoneColor("2408 U", "#597865")},
            {1402,  new PantoneColor("2409 C", "#4b6447")},
            {1403,  new PantoneColor("2409 U", "#637364")},
            {1404,  new PantoneColor("241", "#ad0075")},
            {1405,  new PantoneColor("241 C", "#b41782")},
            {1406,  new PantoneColor("241 U", "#b15389")},
            {1407,  new PantoneColor("2410 C", "#415a3d")},
            {1408,  new PantoneColor("2410 U", "#5f6e5f")},
            {1409,  new PantoneColor("2411 C", "#1a4020")},
            {1410,  new PantoneColor("2411 U", "#4a6149")},
            {1411,  new PantoneColor("2412 C", "#3ad398")},
            {1412,  new PantoneColor("2412 U", "#5bd8a2")},
            {1413,  new PantoneColor("2413 C", "#29b58f")},
            {1414,  new PantoneColor("2413 U", "#47af8e")},
            {1415,  new PantoneColor("2414 C", "#00b980")},
            {1416,  new PantoneColor("2414 U", "#24b280")},
            {1417,  new PantoneColor("2415", "#9b0070")},
            {1418,  new PantoneColor("2415 C", "#a2007c")},
            {1419,  new PantoneColor("2415 U", "#ae5490")},
            {1420,  new PantoneColor("2416 C", "#00ae77")},
            {1421,  new PantoneColor("2416 U", "#17ae81")},
            {1422,  new PantoneColor("2417 C", "#189b6b")},
            {1423,  new PantoneColor("2417 U", "#4e9c79")},
            {1424,  new PantoneColor("2418 C", "#008440")},
            {1425,  new PantoneColor("2418 U", "#00845a")},
            {1426,  new PantoneColor("2419 C", "#007a57")},
            {1427,  new PantoneColor("2419 U", "#367b68")},
            {1428,  new PantoneColor("242", "#7c1c51")},
            {1429,  new PantoneColor("242 C", "#83225e")},
            {1430,  new PantoneColor("242 U", "#8e5975")},
            {1431,  new PantoneColor("2420 C", "#00c460")},
            {1432,  new PantoneColor("2420 U", "#1cc574")},
            {1433,  new PantoneColor("2421 C", "#1ab500")},
            {1434,  new PantoneColor("2421 U", "#44b738")},
            {1435,  new PantoneColor("2422 C", "#00a52e")},
            {1436,  new PantoneColor("2422 U", "#31a557")},
            {1437,  new PantoneColor("2423 C", "#00a815")},
            {1438,  new PantoneColor("2423 U", "#00aa49")},
            {1439,  new PantoneColor("2424 C", "#1a9d00")},
            {1440,  new PantoneColor("2424 U", "#46a23a")},
            {1441,  new PantoneColor("2425", "#87005b")},
            {1442,  new PantoneColor("2425 C", "#880063")},
            {1443,  new PantoneColor("2425 U", "#98537f")},
            {1444,  new PantoneColor("2426 C", "#008918")},
            {1445,  new PantoneColor("2426 U", "#009247")},
            {1446,  new PantoneColor("2427 C", "#005d1c")},
            {1447,  new PantoneColor("2427 U", "#44704a")},
            {1448,  new PantoneColor("243", "#f2bad8")},
            {1449,  new PantoneColor("243 C", "#eeb7e2")},
            {1450,  new PantoneColor("243 U", "#f4b1e4")},
            {1451,  new PantoneColor("244", "#eda0d3")},
            {1452,  new PantoneColor("244 C", "#e99bda")},
            {1453,  new PantoneColor("244 U", "#ee9add")},
            {1454,  new PantoneColor("245", "#e87fc9")},
            {1455,  new PantoneColor("245 C", "#e37ed1")},
            {1456,  new PantoneColor("245 U", "#e47ece")},
            {1457,  new PantoneColor("246", "#cc00a0")},
            {1458,  new PantoneColor("246 C", "#cd25af")},
            {1459,  new PantoneColor("246 U", "#d356b1")},
            {1460,  new PantoneColor("247", "#b7008e")},
            {1461,  new PantoneColor("247 C", "#c114a1")},
            {1462,  new PantoneColor("247 U", "#c150a0")},
            {1463,  new PantoneColor("248", "#a3057f")},
            {1464,  new PantoneColor("248 C", "#a9198d")},
            {1465,  new PantoneColor("248 U", "#a44e8a")},
            {1466,  new PantoneColor("249", "#7f2860")},
            {1467,  new PantoneColor("249 C", "#84266a")},
            {1468,  new PantoneColor("249 U", "#895677")},
            {1469,  new PantoneColor("250", "#edc4dd")},
            {1470,  new PantoneColor("250 C", "#eab9e4")},
            {1471,  new PantoneColor("250 U", "#f0b8e7")},
            {1472,  new PantoneColor("251", "#e29ed6")},
            {1473,  new PantoneColor("251 C", "#e19bdf")},
            {1474,  new PantoneColor("251 U", "#e495dd")},
            {1475,  new PantoneColor("252", "#d36bc6")},
            {1476,  new PantoneColor("252 C", "#d162cd")},
            {1477,  new PantoneColor("252 U", "#d16fcb")},
            {1478,  new PantoneColor("253", "#af23a5")},
            {1479,  new PantoneColor("253 C", "#b319ab")},
            {1480,  new PantoneColor("253 U", "#b856ac")},
            {1481,  new PantoneColor("254", "#a02d96")},
            {1482,  new PantoneColor("254 C", "#9e1a96")},
            {1483,  new PantoneColor("254 U", "#a15499")},
            {1484,  new PantoneColor("255", "#772d6b")},
            {1485,  new PantoneColor("255 C", "#77216c")},
            {1486,  new PantoneColor("255 U", "#83577c")},
            {1487,  new PantoneColor("256", "#e5c4d6")},
            {1488,  new PantoneColor("256 C", "#dabddc")},
            {1489,  new PantoneColor("256 U", "#d5b4da")},
            {1490,  new PantoneColor("2562", "#d8a8d8")},
            {1491,  new PantoneColor("2562 C", "#dba8e2")},
            {1492,  new PantoneColor("2562 U", "#dface8")},
            {1493,  new PantoneColor("2563", "#d1a0cc")},
            {1494,  new PantoneColor("2563 C", "#cea2d7")},
            {1495,  new PantoneColor("2563 U", "#cfa1d9")},
            {1496,  new PantoneColor("2567", "#bf93cc")},
            {1497,  new PantoneColor("2567 C", "#c49fd8")},
            {1498,  new PantoneColor("2567 U", "#c19eda")},
            {1499,  new PantoneColor("257", "#d3a5c9")},
            {1500,  new PantoneColor("257 C", "#c9a0ce")},
            {1501,  new PantoneColor("257 U", "#c499c9")},
            {1502,  new PantoneColor("2572", "#c687d1")},
            {1503,  new PantoneColor("2572 C", "#cc8ada")},
            {1504,  new PantoneColor("2572 U", "#d08fdc")},
            {1505,  new PantoneColor("2573", "#ba7cbc")},
            {1506,  new PantoneColor("2573 C", "#bc83c9")},
            {1507,  new PantoneColor("2573 U", "#ba87ca")},
            {1508,  new PantoneColor("2577", "#aa72bf")},
            {1509,  new PantoneColor("2577 C", "#aa7bc9")},
            {1510,  new PantoneColor("2577 U", "#a47ec5")},
            {1511,  new PantoneColor("258", "#9b4f96")},
            {1512,  new PantoneColor("258 C", "#904799")},
            {1513,  new PantoneColor("258 U", "#a275ad")},
            {1514,  new PantoneColor("2582", "#aa47ba")},
            {1515,  new PantoneColor("2582 C", "#b24ec4")},
            {1516,  new PantoneColor("2582 U", "#bd75ce")},
            {1517,  new PantoneColor("2583", "#9e4fa5")},
            {1518,  new PantoneColor("2583 C", "#a35db4")},
            {1519,  new PantoneColor("2583 U", "#a571b5")},
            {1520,  new PantoneColor("2587", "#8e47ad")},
            {1521,  new PantoneColor("2587 C", "#8446ac")},
            {1522,  new PantoneColor("2587 U", "#936cb5")},
            {1523,  new PantoneColor("259", "#72166b")},
            {1524,  new PantoneColor("259 C", "#702076")},
            {1525,  new PantoneColor("259 U", "#95659b")},
            {1526,  new PantoneColor("2592", "#930fa5")},
            {1527,  new PantoneColor("2592 C", "#9f26b4")},
            {1528,  new PantoneColor("2592 U", "#ad60be")},
            {1529,  new PantoneColor("2593", "#872b93")},
            {1530,  new PantoneColor("2593 C", "#873299")},
            {1531,  new PantoneColor("2593 U", "#8f5e9f")},
            {1532,  new PantoneColor("2597", "#66008c")},
            {1533,  new PantoneColor("2597 C", "#5d0c8b")},
            {1534,  new PantoneColor("2597 U", "#825aa3")},
            {1535,  new PantoneColor("260", "#681e5b")},
            {1536,  new PantoneColor("260 C", "#672565")},
            {1537,  new PantoneColor("260 U", "#8b648c")},
            {1538,  new PantoneColor("2602", "#820c8e")},
            {1539,  new PantoneColor("2602 C", "#8b189b")},
            {1540,  new PantoneColor("2602 U", "#9a57a5")},
            {1541,  new PantoneColor("2603", "#70147a")},
            {1542,  new PantoneColor("2603 C", "#732181")},
            {1543,  new PantoneColor("2603 U", "#86588f")},
            {1544,  new PantoneColor("2607", "#5b027a")},
            {1545,  new PantoneColor("2607 C", "#520975")},
            {1546,  new PantoneColor("2607 U", "#7a5894")},
            {1547,  new PantoneColor("261", "#5e2154")},
            {1548,  new PantoneColor("261 C", "#5f285e")},
            {1549,  new PantoneColor("261 U", "#816181")},
            {1550,  new PantoneColor("2612", "#701e72")},
            {1551,  new PantoneColor("2612 C", "#7b2481")},
            {1552,  new PantoneColor("2612 U", "#88558c")},
            {1553,  new PantoneColor("2613", "#66116d")},
            {1554,  new PantoneColor("2613 C", "#6a1e74")},
            {1555,  new PantoneColor("2613 U", "#7f5685")},
            {1556,  new PantoneColor("2617", "#560c70")},
            {1557,  new PantoneColor("2617 C", "#490c66")},
            {1558,  new PantoneColor("2617 U", "#745387")},
            {1559,  new PantoneColor("262", "#542344")},
            {1560,  new PantoneColor("262 C", "#54274e")},
            {1561,  new PantoneColor("262 U", "#765d73")},
            {1562,  new PantoneColor("2622", "#602d59")},
            {1563,  new PantoneColor("2622 C", "#682f64")},
            {1564,  new PantoneColor("2622 U", "#7d5a79")},
            {1565,  new PantoneColor("2623", "#5b195e")},
            {1566,  new PantoneColor("2623 C", "#621f65")},
            {1567,  new PantoneColor("2623 U", "#76547a")},
            {1568,  new PantoneColor("2627", "#4c145e")},
            {1569,  new PantoneColor("2627 C", "#3e1051")},
            {1570,  new PantoneColor("2627 U", "#6d527a")},
            {1571,  new PantoneColor("263", "#e0cee0")},
            {1572,  new PantoneColor("263 C", "#dac4e5")},
            {1573,  new PantoneColor("263 U", "#dcc4e8")},
            {1574,  new PantoneColor("2635", "#c9add8")},
            {1575,  new PantoneColor("2635 C", "#c6b3e1")},
            {1576,  new PantoneColor("2635 U", "#c8b6e5")},
            {1577,  new PantoneColor("264", "#c6aadb")},
            {1578,  new PantoneColor("264 C", "#c4a6e1")},
            {1579,  new PantoneColor("264 U", "#bfa0e3")},
            {1580,  new PantoneColor("2645", "#b591d1")},
            {1581,  new PantoneColor("2645 C", "#b095da")},
            {1582,  new PantoneColor("2645 U", "#b8a2e2")},
            {1583,  new PantoneColor("265", "#9663c4")},
            {1584,  new PantoneColor("265 C", "#9363cc")},
            {1585,  new PantoneColor("265 U", "#9d7ad2")},
            {1586,  new PantoneColor("2655", "#9b6dc6")},
            {1587,  new PantoneColor("2655 C", "#9678d2")},
            {1588,  new PantoneColor("2655 U", "#a188d7")},
            {1589,  new PantoneColor("266", "#6d28aa")},
            {1590,  new PantoneColor("266 C", "#783cbd")},
            {1591,  new PantoneColor("266 U", "#8a66c2")},
            {1592,  new PantoneColor("2665", "#894fbf")},
            {1593,  new PantoneColor("2665 C", "#7f56c5")},
            {1594,  new PantoneColor("2665 U", "#8b70c8")},
            {1595,  new PantoneColor("267", "#59118e")},
            {1596,  new PantoneColor("267 C", "#62259d")},
            {1597,  new PantoneColor("267 U", "#7f5dac")},
            {1598,  new PantoneColor("268", "#4f2170")},
            {1599,  new PantoneColor("268 C", "#5a2b81")},
            {1600,  new PantoneColor("268 U", "#735990")},
            {1601,  new PantoneColor("2685", "#56008c")},
            {1602,  new PantoneColor("2685 C", "#32006e")},
            {1603,  new PantoneColor("2685 U", "#735ba5")},
            {1604,  new PantoneColor("269", "#442359")},
            {1605,  new PantoneColor("269 C", "#532c6c")},
            {1606,  new PantoneColor("269 U", "#6e577e")},
            {1607,  new PantoneColor("2695", "#44235e")},
            {1608,  new PantoneColor("2695 C", "#2f1a45")},
            {1609,  new PantoneColor("2695 U", "#6b5d7e")},
            {1610,  new PantoneColor("270", "#baafd3")},
            {1611,  new PantoneColor("270 C", "#b6b3df")},
            {1612,  new PantoneColor("270 U", "#adaddd")},
            {1613,  new PantoneColor("2705", "#ad9ed3")},
            {1614,  new PantoneColor("2705 C", "#a9a3df")},
            {1615,  new PantoneColor("2705 U", "#b8b4e8")},
            {1616,  new PantoneColor("2706", "#d1cedd")},
            {1617,  new PantoneColor("2706 C", "#ccd2e9")},
            {1618,  new PantoneColor("2706 U", "#cad3f0")},
            {1619,  new PantoneColor("2707", "#bfd1e5")},
            {1620,  new PantoneColor("2707 C", "#c4d5ec")},
            {1621,  new PantoneColor("2707 U", "#c6daf5")},
            {1622,  new PantoneColor("2708", "#afbcdb")},
            {1623,  new PantoneColor("2708 C", "#b9cbea")},
            {1624,  new PantoneColor("2708 U", "#b2c8ee")},
            {1625,  new PantoneColor("271", "#9e91c6")},
            {1626,  new PantoneColor("271 C", "#9794d2")},
            {1627,  new PantoneColor("271 U", "#9a9ad4")},
            {1628,  new PantoneColor("2715", "#937acc")},
            {1629,  new PantoneColor("2715 C", "#8b83d6")},
            {1630,  new PantoneColor("2715 U", "#9c98df")},
            {1631,  new PantoneColor("2716", "#a5a0d6")},
            {1632,  new PantoneColor("2716 C", "#9fade4")},
            {1633,  new PantoneColor("2716 U", "#a1aee9")},
            {1634,  new PantoneColor("2717", "#a5bae0")},
            {1635,  new PantoneColor("2717 C", "#a7c5ed")},
            {1636,  new PantoneColor("2717 U", "#a7c7f3")},
            {1637,  new PantoneColor("2718", "#5b77cc")},
            {1638,  new PantoneColor("2718 C", "#5a87d9")},
            {1639,  new PantoneColor("2718 U", "#6786d7")},
            {1640,  new PantoneColor("272", "#8977ba")},
            {1641,  new PantoneColor("272 C", "#7573c0")},
            {1642,  new PantoneColor("272 U", "#8585c5")},
            {1643,  new PantoneColor("2725", "#7251bc")},
            {1644,  new PantoneColor("2725 C", "#675dc6")},
            {1645,  new PantoneColor("2725 U", "#8880d2")},
            {1646,  new PantoneColor("2726", "#6656bc")},
            {1647,  new PantoneColor("2726 C", "#455cc7")},
            {1648,  new PantoneColor("2726 U", "#6e7ace")},
            {1649,  new PantoneColor("2727", "#5e68c4")},
            {1650,  new PantoneColor("2727 C", "#2e7de1")},
            {1651,  new PantoneColor("2727 U", "#618ee8")},
            {1652,  new PantoneColor("2728", "#3044b5")},
            {1653,  new PantoneColor("2728 C", "#0047ba")},
            {1654,  new PantoneColor("2728 U", "#4d68c1")},
            {1655,  new PantoneColor("273", "#38197a")},
            {1656,  new PantoneColor("273 C", "#23135e")},
            {1657,  new PantoneColor("273 U", "#645d9a")},
            {1658,  new PantoneColor("2735", "#4f0093")},
            {1659,  new PantoneColor("2735 C", "#290088")},
            {1660,  new PantoneColor("2735 U", "#6658b0")},
            {1661,  new PantoneColor("2736", "#4930ad")},
            {1662,  new PantoneColor("2736 C", "#1724a9")},
            {1663,  new PantoneColor("2736 U", "#5960b9")},
            {1664,  new PantoneColor("2738", "#2d008e")},
            {1665,  new PantoneColor("2738 C", "#00098b")},
            {1666,  new PantoneColor("2738 U", "#424da3")},
            {1667,  new PantoneColor("274", "#2b1166")},
            {1668,  new PantoneColor("274 C", "#211650")},
            {1669,  new PantoneColor("274 U", "#5f578a")},
            {1670,  new PantoneColor("2745", "#3f0077")},
            {1671,  new PantoneColor("2745 C", "#250670")},
            {1672,  new PantoneColor("2745 U", "#5f5499")},
            {1673,  new PantoneColor("2746", "#3f2893")},
            {1674,  new PantoneColor("2746 C", "#101e8e")},
            {1675,  new PantoneColor("2746 U", "#565da3")},
            {1676,  new PantoneColor("2747", "#1c146b")},
            {1677,  new PantoneColor("2747 C", "#001a71")},
            {1678,  new PantoneColor("2747 U", "#3f4f90")},
            {1679,  new PantoneColor("2748", "#1e1c77")},
            {1680,  new PantoneColor("2748 C", "#001970")},
            {1681,  new PantoneColor("2748 U", "#454f8c")},
            {1682,  new PantoneColor("275", "#260f54")},
            {1683,  new PantoneColor("275 C", "#211646")},
            {1684,  new PantoneColor("275 U", "#5c5582")},
            {1685,  new PantoneColor("2755", "#35006d")},
            {1686,  new PantoneColor("2755 C", "#221060")},
            {1687,  new PantoneColor("2755 U", "#5b5389")},
            {1688,  new PantoneColor("2756", "#332875")},
            {1689,  new PantoneColor("2756 C", "#121f6b")},
            {1690,  new PantoneColor("2756 U", "#565b8b")},
            {1691,  new PantoneColor("2757", "#141654")},
            {1692,  new PantoneColor("2757 C", "#001e5f")},
            {1693,  new PantoneColor("2757 U", "#444e7d")},
            {1694,  new PantoneColor("2758", "#192168")},
            {1695,  new PantoneColor("2758 C", "#001d60")},
            {1696,  new PantoneColor("2758 U", "#464d79")},
            {1697,  new PantoneColor("276", "#2b2147")},
            {1698,  new PantoneColor("276 C", "#231c34")},
            {1699,  new PantoneColor("276 U", "#5b546d")},
            {1700,  new PantoneColor("2765", "#2b0c56")},
            {1701,  new PantoneColor("2765 C", "#201545")},
            {1702,  new PantoneColor("2765 U", "#574f76")},
            {1703,  new PantoneColor("2766", "#2b265b")},
            {1704,  new PantoneColor("2766 C", "#131b4d")},
            {1705,  new PantoneColor("2766 U", "#57597b")},
            {1706,  new PantoneColor("2767", "#14213d")},
            {1707,  new PantoneColor("2767 C", "#14284b")},
            {1708,  new PantoneColor("2767 U", "#484b63")},
            {1709,  new PantoneColor("2768", "#112151")},
            {1710,  new PantoneColor("2768 C", "#051c48")},
            {1711,  new PantoneColor("2768 U", "#494c6b")},
            {1712,  new PantoneColor("277", "#b5d1e8")},
            {1713,  new PantoneColor("277 C", "#adc8e7")},
            {1714,  new PantoneColor("277 U", "#accdf1")},
            {1715,  new PantoneColor("278", "#99badd")},
            {1716,  new PantoneColor("278 C", "#8cb7e8")},
            {1717,  new PantoneColor("278 U", "#8bb8ed")},
            {1718,  new PantoneColor("279", "#6689cc")},
            {1719,  new PantoneColor("279 C", "#3e8ddd")},
            {1720,  new PantoneColor("279 U", "#578dda")},
            {1721,  new PantoneColor("280", "#002b7f")},
            {1722,  new PantoneColor("280 C", "#012168")},
            {1723,  new PantoneColor("280 U", "#3a487f")},
            {1724,  new PantoneColor("281", "#002868")},
            {1725,  new PantoneColor("281 C", "#001f5b")},
            {1726,  new PantoneColor("281 U", "#3f4974")},
            {1727,  new PantoneColor("282", "#002654")},
            {1728,  new PantoneColor("282 C", "#031d40")},
            {1729,  new PantoneColor("282 U", "#414765")},
            {1730,  new PantoneColor("283", "#9bc4e2")},
            {1731,  new PantoneColor("283 C", "#94c0e9")},
            {1732,  new PantoneColor("283 U", "#9ac5ed")},
            {1733,  new PantoneColor("284", "#75aadb")},
            {1734,  new PantoneColor("284 C", "#6caae4")},
            {1735,  new PantoneColor("284 U", "#76afe8")},
            {1736,  new PantoneColor("285", "#3a75c4")},
            {1737,  new PantoneColor("285 C", "#0070cd")},
            {1738,  new PantoneColor("285 U", "#4280cf")},
            {1739,  new PantoneColor("286", "#0038a8")},
            {1740,  new PantoneColor("286 C", "#0032a0")},
            {1741,  new PantoneColor("286 U", "#2c54a3")},
            {1742,  new PantoneColor("287", "#003893")},
            {1743,  new PantoneColor("287 C", "#002f86")},
            {1744,  new PantoneColor("287 U", "#395796")},
            {1745,  new PantoneColor("288", "#00337f")},
            {1746,  new PantoneColor("288 C", "#002c73")},
            {1747,  new PantoneColor("288 U", "#3b5486")},
            {1748,  new PantoneColor("289", "#002649")},
            {1749,  new PantoneColor("289 C", "#0c223f")},
            {1750,  new PantoneColor("289 U", "#424e6a")},
            {1751,  new PantoneColor("290", "#c4d8e2")},
            {1752,  new PantoneColor("290 C", "#bad8ea")},
            {1753,  new PantoneColor("290 U", "#a5d2ee")},
            {1754,  new PantoneColor("2905", "#93c6e0")},
            {1755,  new PantoneColor("2905 C", "#8fc6e8")},
            {1756,  new PantoneColor("2905 U", "#88c7ed")},
            {1757,  new PantoneColor("291", "#a8cee2")},
            {1758,  new PantoneColor("291 C", "#99caea")},
            {1759,  new PantoneColor("291 U", "#7cbceb")},
            {1760,  new PantoneColor("2915", "#60afdd")},
            {1761,  new PantoneColor("2915 C", "#61b3e4")},
            {1762,  new PantoneColor("2915 U", "#61b1e8")},
            {1763,  new PantoneColor("292", "#75b2dd")},
            {1764,  new PantoneColor("292 C", "#67b2e7")},
            {1765,  new PantoneColor("292 U", "#5fa7e5")},
            {1766,  new PantoneColor("2925", "#008ed6")},
            {1767,  new PantoneColor("2925 C", "#009add")},
            {1768,  new PantoneColor("2925 U", "#3795da")},
            {1769,  new PantoneColor("293", "#0051ba")},
            {1770,  new PantoneColor("293 C", "#003ca6")},
            {1771,  new PantoneColor("293 U", "#1a59a8")},
            {1772,  new PantoneColor("2935", "#005bbf")},
            {1773,  new PantoneColor("2935 C", "#0055b7")},
            {1774,  new PantoneColor("2935 U", "#0f5ea9")},
            {1775,  new PantoneColor("294", "#003f87")},
            {1776,  new PantoneColor("294 C", "#002e6c")},
            {1777,  new PantoneColor("294 U", "#385888")},
            {1778,  new PantoneColor("2945", "#0054a0")},
            {1779,  new PantoneColor("2945 C", "#004a97")},
            {1780,  new PantoneColor("2945 U", "#26578b")},
            {1781,  new PantoneColor("295", "#00386b")},
            {1782,  new PantoneColor("295 C", "#002855")},
            {1783,  new PantoneColor("295 U", "#344f71")},
            {1784,  new PantoneColor("2955", "#003d6b")},
            {1785,  new PantoneColor("2955 C", "#003763")},
            {1786,  new PantoneColor("2955 U", "#395575")},
            {1787,  new PantoneColor("296", "#002d47")},
            {1788,  new PantoneColor("296 C", "#061b2b")},
            {1789,  new PantoneColor("296 U", "#424e5f")},
            {1790,  new PantoneColor("2965", "#00334c")},
            {1791,  new PantoneColor("2965 C", "#00253d")},
            {1792,  new PantoneColor("2965 U", "#3a5165")},
            {1793,  new PantoneColor("297", "#82c6e2")},
            {1794,  new PantoneColor("297 C", "#6ec4e8")},
            {1795,  new PantoneColor("297 U", "#79caed")},
            {1796,  new PantoneColor("2975", "#bae0e2")},
            {1797,  new PantoneColor("2975 C", "#97d4e9")},
            {1798,  new PantoneColor("2975 U", "#88d4ee")},
            {1799,  new PantoneColor("298", "#51b5e0")},
            {1800,  new PantoneColor("298 C", "#40b4e5")},
            {1801,  new PantoneColor("298 U", "#47b2e8")},
            {1802,  new PantoneColor("2985", "#51bfe2")},
            {1803,  new PantoneColor("2985 C", "#57c0e8")},
            {1804,  new PantoneColor("2985 U", "#41b5e6")},
            {1805,  new PantoneColor("299", "#00a3dd")},
            {1806,  new PantoneColor("299 C", "#00a0df")},
            {1807,  new PantoneColor("299 U", "#0093d9")},
            {1808,  new PantoneColor("2995", "#00a5db")},
            {1809,  new PantoneColor("2995 C", "#00a7e1")},
            {1810,  new PantoneColor("2995 U", "#009adc")},
            {1811,  new PantoneColor("300", "#0072c6")},
            {1812,  new PantoneColor("300 C", "#005cb8")},
            {1813,  new PantoneColor("300 U", "#006cb7")},
            {1814,  new PantoneColor("3005", "#0084c9")},
            {1815,  new PantoneColor("3005 C", "#0074c8")},
            {1816,  new PantoneColor("3005 U", "#0076bf")},
            {1817,  new PantoneColor("301", "#005b99")},
            {1818,  new PantoneColor("301 C", "#004987")},
            {1819,  new PantoneColor("301 U", "#26608d")},
            {1820,  new PantoneColor("3015", "#00709e")},
            {1821,  new PantoneColor("3015 C", "#005f9b")},
            {1822,  new PantoneColor("3015 U", "#176995")},
            {1823,  new PantoneColor("302", "#004f6d")},
            {1824,  new PantoneColor("302 C", "#003a5c")},
            {1825,  new PantoneColor("302 U", "#345c76")},
            {1826,  new PantoneColor("3025", "#00546b")},
            {1827,  new PantoneColor("3025 C", "#004d71")},
            {1828,  new PantoneColor("3025 U", "#345f79")},
            {1829,  new PantoneColor("303 C", "#012939")},
            {1830,  new PantoneColor("303 U", "#3e5565")},
            {1831,  new PantoneColor("3035", "#004454")},
            {1832,  new PantoneColor("3035 C", "#003d51")},
            {1833,  new PantoneColor("3035 U", "#3e5665")},
            {1834,  new PantoneColor("304", "#a5dde2")},
            {1835,  new PantoneColor("304 C", "#98dae9")},
            {1836,  new PantoneColor("304 U", "#8adbec")},
            {1837,  new PantoneColor("305", "#70cee2")},
            {1838,  new PantoneColor("305 C", "#57c8e7")},
            {1839,  new PantoneColor("305 U", "#49c8ec")},
            {1840,  new PantoneColor("306", "#00bce2")},
            {1841,  new PantoneColor("306 C", "#00b2e2")},
            {1842,  new PantoneColor("306 U", "#00b2e5")},
            {1843,  new PantoneColor("307 C", "#0069a6")},
            {1844,  new PantoneColor("307 U", "#0071a2")},
            {1845,  new PantoneColor("308", "#00607c")},
            {1846,  new PantoneColor("308 C", "#00567c")},
            {1847,  new PantoneColor("308 U", "#206682")},
            {1848,  new PantoneColor("309", "#003f49")},
            {1849,  new PantoneColor("309 C", "#003a49")},
            {1850,  new PantoneColor("309 U", "#3c5763")},
            {1851,  new PantoneColor("310", "#72d1dd")},
            {1852,  new PantoneColor("310 C", "#66cfe3")},
            {1853,  new PantoneColor("310 U", "#55cee6")},
            {1854,  new PantoneColor("3105", "#7fd6db")},
            {1855,  new PantoneColor("3105 C", "#62d0df")},
            {1856,  new PantoneColor("3105 U", "#42ccdf")},
            {1857,  new PantoneColor("311", "#28c4d8")},
            {1858,  new PantoneColor("311 C", "#00c1de")},
            {1859,  new PantoneColor("311 U", "#00bbdc")},
            {1860,  new PantoneColor("3115", "#2dc6d6")},
            {1861,  new PantoneColor("3115 C", "#00bfd5")},
            {1862,  new PantoneColor("3115 U", "#00bcd4")},
            {1863,  new PantoneColor("312", "#00adc6")},
            {1864,  new PantoneColor("312 C", "#00a6ce")},
            {1865,  new PantoneColor("312 U", "#00abd1")},
            {1866,  new PantoneColor("3125", "#00b7c6")},
            {1867,  new PantoneColor("3125 C", "#00abc7")},
            {1868,  new PantoneColor("3125 U", "#00a8c3")},
            {1869,  new PantoneColor("313", "#0099b5")},
            {1870,  new PantoneColor("313 C", "#008fbe")},
            {1871,  new PantoneColor("313 U", "#008ab3")},
            {1872,  new PantoneColor("3135", "#009baa")},
            {1873,  new PantoneColor("3135 C", "#008aab")},
            {1874,  new PantoneColor("3135 U", "#008aa7")},
            {1875,  new PantoneColor("314", "#00829b")},
            {1876,  new PantoneColor("314 C", "#007da4")},
            {1877,  new PantoneColor("314 U", "#007b9b")},
            {1878,  new PantoneColor("3145", "#00848e")},
            {1879,  new PantoneColor("3145 C", "#00748c")},
            {1880,  new PantoneColor("3145 U", "#007588")},
            {1881,  new PantoneColor("315", "#006b77")},
            {1882,  new PantoneColor("315 C", "#00657f")},
            {1883,  new PantoneColor("315 U", "#1c6578")},
            {1884,  new PantoneColor("3155", "#006d75")},
            {1885,  new PantoneColor("3155 C", "#005f71")},
            {1886,  new PantoneColor("3155 U", "#186676")},
            {1887,  new PantoneColor("316", "#00494f")},
            {1888,  new PantoneColor("316 C", "#00464f")},
            {1889,  new PantoneColor("316 U", "#3b5861")},
            {1890,  new PantoneColor("3165", "#00565b")},
            {1891,  new PantoneColor("3165 C", "#004d58")},
            {1892,  new PantoneColor("3165 U", "#2d5a65")},
            {1893,  new PantoneColor("317", "#c9e8dd")},
            {1894,  new PantoneColor("317 C", "#b0e2e2")},
            {1895,  new PantoneColor("317 U", "#abe7e7")},
            {1896,  new PantoneColor("318", "#93dddb")},
            {1897,  new PantoneColor("318 C", "#86dade")},
            {1898,  new PantoneColor("318 U", "#62d7df")},
            {1899,  new PantoneColor("319", "#4cced1")},
            {1900,  new PantoneColor("319 C", "#25cad3")},
            {1901,  new PantoneColor("319 U", "#17c7d1")},
            {1902,  new PantoneColor("320", "#009ea0")},
            {1903,  new PantoneColor("320 C", "#0099a8")},
            {1904,  new PantoneColor("320 U", "#0099a6")},
            {1905,  new PantoneColor("321", "#008789")},
            {1906,  new PantoneColor("321 C", "#008995")},
            {1907,  new PantoneColor("321 U", "#00808b")},
            {1908,  new PantoneColor("322", "#007272")},
            {1909,  new PantoneColor("322 C", "#007078")},
            {1910,  new PantoneColor("322 U", "#0f7179")},
            {1911,  new PantoneColor("323", "#006663")},
            {1912,  new PantoneColor("323 C", "#005d62")},
            {1913,  new PantoneColor("323 U", "#2c5f64")},
            {1914,  new PantoneColor("324", "#aaddd6")},
            {1915,  new PantoneColor("324 C", "#9bd9d9")},
            {1916,  new PantoneColor("324 U", "#7fd6d6")},
            {1917,  new PantoneColor("3242", "#87ddd1")},
            {1918,  new PantoneColor("3242 C", "#6edad5")},
            {1919,  new PantoneColor("3242 U", "#54d9d3")},
            {1920,  new PantoneColor("3245", "#8ce0d1")},
            {1921,  new PantoneColor("3245 C", "#7aded4")},
            {1922,  new PantoneColor("3245 U", "#45d9cc")},
            {1923,  new PantoneColor("3248", "#7ad3c1")},
            {1924,  new PantoneColor("3248 C", "#6dcbb8")},
            {1925,  new PantoneColor("3248 U", "#65ccba")},
            {1926,  new PantoneColor("325", "#56c9c1")},
            {1927,  new PantoneColor("325 C", "#64cbc9")},
            {1928,  new PantoneColor("325 U", "#35bebb")},
            {1929,  new PantoneColor("3252", "#56d6c9")},
            {1930,  new PantoneColor("3252 C", "#1bcfc9")},
            {1931,  new PantoneColor("3252 U", "#00cac3")},
            {1932,  new PantoneColor("3255", "#47d6c1")},
            {1933,  new PantoneColor("3255 C", "#22d3c5")},
            {1934,  new PantoneColor("3255 U", "#00ccbc")},
            {1935,  new PantoneColor("3258", "#35c4af")},
            {1936,  new PantoneColor("3258 C", "#48c3b1")},
            {1937,  new PantoneColor("3258 U", "#43beac")},
            {1938,  new PantoneColor("326", "#00b2aa")},
            {1939,  new PantoneColor("326 C", "#00afa9")},
            {1940,  new PantoneColor("3262", "#00c1b5")},
            {1941,  new PantoneColor("3262 C", "#00bbb3")},
            {1942,  new PantoneColor("3262 U", "#00b7b1")},
            {1943,  new PantoneColor("3265", "#00c6b2")},
            {1944,  new PantoneColor("3265 C", "#00c4b3")},
            {1945,  new PantoneColor("3265 U", "#00bcac")},
            {1946,  new PantoneColor("3268", "#00af99")},
            {1947,  new PantoneColor("3268 C", "#00a98e")},
            {1948,  new PantoneColor("3268 U", "#1eaf99")},
            {1949,  new PantoneColor("327 C", "#008374")},
            {1950,  new PantoneColor("3272", "#00aa9e")},
            {1951,  new PantoneColor("3272 C", "#00a19a")},
            {1952,  new PantoneColor("3272 U", "#00a19c")},
            {1953,  new PantoneColor("3275", "#00b2a0")},
            {1954,  new PantoneColor("3275 C", "#00af9a")},
            {1955,  new PantoneColor("3275 U", "#00a694")},
            {1956,  new PantoneColor("3278", "#009b84")},
            {1957,  new PantoneColor("3278 C", "#009877")},
            {1958,  new PantoneColor("3278 U", "#009982")},
            {1959,  new PantoneColor("328", "#007770")},
            {1960,  new PantoneColor("328 C", "#007166")},
            {1961,  new PantoneColor("328 U", "#077b79")},
            {1962,  new PantoneColor("3282", "#008c82")},
            {1963,  new PantoneColor("3282 C", "#00837a")},
            {1964,  new PantoneColor("3282 U", "#008480")},
            {1965,  new PantoneColor("3285", "#009987")},
            {1966,  new PantoneColor("3285 C", "#009382")},
            {1967,  new PantoneColor("3285 U", "#008d82")},
            {1968,  new PantoneColor("3288", "#008270")},
            {1969,  new PantoneColor("3288 C", "#008064")},
            {1970,  new PantoneColor("3288 U", "#158576")},
            {1971,  new PantoneColor("329", "#006d66")},
            {1972,  new PantoneColor("329 C", "#00665e")},
            {1973,  new PantoneColor("329 U", "#2a7372")},
            {1974,  new PantoneColor("3292", "#006056")},
            {1975,  new PantoneColor("3292 C", "#00574f")},
            {1976,  new PantoneColor("3292 U", "#306c6b")},
            {1977,  new PantoneColor("3295", "#008272")},
            {1978,  new PantoneColor("3295 C", "#007564")},
            {1979,  new PantoneColor("3295 U", "#1c7d74")},
            {1980,  new PantoneColor("3298", "#006b5b")},
            {1981,  new PantoneColor("3298 C", "#006852")},
            {1982,  new PantoneColor("3298 U", "#367267")},
            {1983,  new PantoneColor("330", "#005951")},
            {1984,  new PantoneColor("330 C", "#00514b")},
            {1985,  new PantoneColor("330 U", "#416261")},
            {1986,  new PantoneColor("3302", "#00493f")},
            {1987,  new PantoneColor("3302 C", "#004b44")},
            {1988,  new PantoneColor("3302 U", "#3e5f5e")},
            {1989,  new PantoneColor("3305", "#004f42")},
            {1990,  new PantoneColor("3305 C", "#004c42")},
            {1991,  new PantoneColor("3305 U", "#436863")},
            {1992,  new PantoneColor("3308", "#004438")},
            {1993,  new PantoneColor("3308 C", "#034436")},
            {1994,  new PantoneColor("3308 U", "#465f5a")},
            {1995,  new PantoneColor("331", "#baead6")},
            {1996,  new PantoneColor("331 C", "#a6e5d8")},
            {1997,  new PantoneColor("331 U", "#8fe6d3")},
            {1998,  new PantoneColor("332", "#a0e5ce")},
            {1999,  new PantoneColor("332 C", "#89e1d0")},
            {2000,  new PantoneColor("332 U", "#6adfcb")},
            {2001,  new PantoneColor("333", "#5eddc1")},
            {2002,  new PantoneColor("333 C", "#33d9c2")},
            {2003,  new PantoneColor("333 U", "#00cfb5")},
            {2004,  new PantoneColor("334", "#00997c")},
            {2005,  new PantoneColor("334 C", "#009578")},
            {2006,  new PantoneColor("334 U", "#009380")},
            {2007,  new PantoneColor("335", "#007c66")},
            {2008,  new PantoneColor("335 C", "#00795f")},
            {2009,  new PantoneColor("335 U", "#1a7c70")},
            {2010,  new PantoneColor("336", "#006854")},
            {2011,  new PantoneColor("336 C", "#00634f")},
            {2012,  new PantoneColor("336 U", "#367068")},
            {2013,  new PantoneColor("337", "#9bdbc1")},
            {2014,  new PantoneColor("337 C", "#8fd4bc")},
            {2015,  new PantoneColor("337 U", "#7ed3b9")},
            {2016,  new PantoneColor("3375", "#8ee2bc")},
            {2017,  new PantoneColor("3375 C", "#76e0c0")},
            {2018,  new PantoneColor("3375 U", "#55deb7")},
            {2019,  new PantoneColor("338", "#7ad1b5")},
            {2020,  new PantoneColor("338 C", "#6dcdb1")},
            {2021,  new PantoneColor("338 U", "#45bfa1")},
            {2022,  new PantoneColor("3385", "#54d8a8")},
            {2023,  new PantoneColor("3385 C", "#3fd4ad")},
            {2024,  new PantoneColor("3385 U", "#2fd2a8")},
            {2025,  new PantoneColor("339", "#00b28c")},
            {2026,  new PantoneColor("339 C", "#00b188")},
            {2027,  new PantoneColor("339 U", "#19ab8a")},
            {2028,  new PantoneColor("3395", "#00c993")},
            {2029,  new PantoneColor("3395 C", "#00c08a")},
            {2030,  new PantoneColor("3395 U", "#00c497")},
            {2031,  new PantoneColor("340", "#009977")},
            {2032,  new PantoneColor("340 C", "#00945d")},
            {2033,  new PantoneColor("340 U", "#009b77")},
            {2034,  new PantoneColor("3405", "#00b27a")},
            {2035,  new PantoneColor("3405 C", "#00ac68")},
            {2036,  new PantoneColor("3405 U", "#00ae7b")},
            {2037,  new PantoneColor("341", "#007a5e")},
            {2038,  new PantoneColor("341 C", "#007852")},
            {2039,  new PantoneColor("341 U", "#317663")},
            {2040,  new PantoneColor("3415", "#007c59")},
            {2041,  new PantoneColor("3415 C", "#007549")},
            {2042,  new PantoneColor("3415 U", "#2c7f66")},
            {2043,  new PantoneColor("342", "#006b54")},
            {2044,  new PantoneColor("342 C", "#006547")},
            {2045,  new PantoneColor("342 U", "#3e6d60")},
            {2046,  new PantoneColor("3425", "#006847")},
            {2047,  new PantoneColor("3425 C", "#006140")},
            {2048,  new PantoneColor("3425 U", "#3d7563")},
            {2049,  new PantoneColor("343", "#00563f")},
            {2050,  new PantoneColor("343 C", "#0d553f")},
            {2051,  new PantoneColor("343 U", "#45645b")},
            {2052,  new PantoneColor("3435", "#024930")},
            {2053,  new PantoneColor("3435 C", "#144633")},
            {2054,  new PantoneColor("3435 U", "#49655a")},
            {2055,  new PantoneColor("344", "#b5e2bf")},
            {2056,  new PantoneColor("344 C", "#a0d8b3")},
            {2057,  new PantoneColor("344 U", "#8bd6ad")},
            {2058,  new PantoneColor("345", "#96d8af")},
            {2059,  new PantoneColor("345 C", "#91d5ab")},
            {2060,  new PantoneColor("345 U", "#68cb9b")},
            {2061,  new PantoneColor("346", "#70ce9b")},
            {2062,  new PantoneColor("346 C", "#6eca97")},
            {2063,  new PantoneColor("346 U", "#49bb89")},
            {2064,  new PantoneColor("347", "#009e60")},
            {2065,  new PantoneColor("347 C", "#009844")},
            {2066,  new PantoneColor("347 U", "#089860")},
            {2067,  new PantoneColor("348", "#008751")},
            {2068,  new PantoneColor("348 C", "#00833d")},
            {2069,  new PantoneColor("348 U", "#2f835b")},
            {2070,  new PantoneColor("349", "#006b3f")},
            {2071,  new PantoneColor("349 C", "#016836")},
            {2072,  new PantoneColor("349 U", "#457157")},
            {2073,  new PantoneColor("350", "#234f33")},
            {2074,  new PantoneColor("350 C", "#2b5034")},
            {2075,  new PantoneColor("350 U", "#536557")},
            {2076,  new PantoneColor("351", "#b5e8bf")},
            {2077,  new PantoneColor("351 C", "#a2e3b9")},
            {2078,  new PantoneColor("351 U", "#8fe4b3")},
            {2079,  new PantoneColor("352", "#99e5b2")},
            {2080,  new PantoneColor("352 C", "#8ce0b0")},
            {2081,  new PantoneColor("352 U", "#6adea3")},
            {2082,  new PantoneColor("353", "#84e2a8")},
            {2083,  new PantoneColor("353 C", "#7bdea7")},
            {2084,  new PantoneColor("353 U", "#43d491")},
            {2085,  new PantoneColor("354", "#00b760")},
            {2086,  new PantoneColor("354 C", "#00ae41")},
            {2087,  new PantoneColor("354 U", "#00a75c")},
            {2088,  new PantoneColor("355", "#009e49")},
            {2089,  new PantoneColor("355 C", "#00953a")},
            {2090,  new PantoneColor("355 U", "#00955e")},
            {2091,  new PantoneColor("356", "#007a3d")},
            {2092,  new PantoneColor("356 C", "#007833")},
            {2093,  new PantoneColor("356 U", "#347c59")},
            {2094,  new PantoneColor("357", "#215b33")},
            {2095,  new PantoneColor("357 C", "#1c5631")},
            {2096,  new PantoneColor("357 U", "#4e6e59")},
            {2097,  new PantoneColor("358", "#aadd96")},
            {2098,  new PantoneColor("358 C", "#acda90")},
            {2099,  new PantoneColor("358 U", "#94d68a")},
            {2100,  new PantoneColor("359", "#a0db8e")},
            {2101,  new PantoneColor("359 C", "#a2d683")},
            {2102,  new PantoneColor("359 U", "#79ca77")},
            {2103,  new PantoneColor("360", "#60c659")},
            {2104,  new PantoneColor("360 C", "#6cc049")},
            {2105,  new PantoneColor("360 U", "#58b660")},
            {2106,  new PantoneColor("361", "#1eb53a")},
            {2107,  new PantoneColor("361 C", "#3fae29")},
            {2108,  new PantoneColor("361 U", "#48a84f")},
            {2109,  new PantoneColor("362", "#339e35")},
            {2110,  new PantoneColor("362 C", "#4d9c2d")},
            {2111,  new PantoneColor("362 U", "#53924f")},
            {2112,  new PantoneColor("363", "#3d8e33")},
            {2113,  new PantoneColor("363 C", "#4b8b2a")},
            {2114,  new PantoneColor("363 U", "#56834c")},
            {2115,  new PantoneColor("364", "#3a7728")},
            {2116,  new PantoneColor("364 C", "#497527")},
            {2117,  new PantoneColor("364 U", "#5a784e")},
            {2118,  new PantoneColor("365", "#d3e8a3")},
            {2119,  new PantoneColor("365 C", "#c2df87")},
            {2120,  new PantoneColor("365 U", "#c0e491")},
            {2121,  new PantoneColor("366", "#c4e58e")},
            {2122,  new PantoneColor("366 C", "#b7dc78")},
            {2123,  new PantoneColor("366 U", "#a6da7b")},
            {2124,  new PantoneColor("367", "#aadd6d")},
            {2125,  new PantoneColor("367 C", "#a3d55d")},
            {2126,  new PantoneColor("367 U", "#8dcf68")},
            {2127,  new PantoneColor("368", "#5bbf21")},
            {2128,  new PantoneColor("368 C", "#77bc1f")},
            {2129,  new PantoneColor("368 U", "#65b146")},
            {2130,  new PantoneColor("369", "#56aa1c")},
            {2131,  new PantoneColor("369 C", "#62a60a")},
            {2132,  new PantoneColor("369 U", "#609e44")},
            {2133,  new PantoneColor("370", "#568e14")},
            {2134,  new PantoneColor("370 C", "#648b1a")},
            {2135,  new PantoneColor("370 U", "#688848")},
            {2136,  new PantoneColor("371", "#566b21")},
            {2137,  new PantoneColor("371 C", "#546121")},
            {2138,  new PantoneColor("371 U", "#66714d")},
            {2139,  new PantoneColor("372", "#d8ed96")},
            {2140,  new PantoneColor("372 C", "#d4eb8d")},
            {2141,  new PantoneColor("372 U", "#d0ee8f")},
            {2142,  new PantoneColor("373", "#ceea82")},
            {2143,  new PantoneColor("373 C", "#cce97f")},
            {2144,  new PantoneColor("373 U", "#b6e871")},
            {2145,  new PantoneColor("374", "#bae860")},
            {2146,  new PantoneColor("374 C", "#c4e76a")},
            {2147,  new PantoneColor("374 U", "#a1e15f")},
            {2148,  new PantoneColor("375", "#8cd600")},
            {2149,  new PantoneColor("375 C", "#94d500")},
            {2150,  new PantoneColor("375 U", "#6bc82c")},
            {2151,  new PantoneColor("376", "#7fba00")},
            {2152,  new PantoneColor("376 C", "#82bc00")},
            {2153,  new PantoneColor("376 U", "#6baa36")},
            {2154,  new PantoneColor("377", "#709302")},
            {2155,  new PantoneColor("377 C", "#799900")},
            {2156,  new PantoneColor("377 U", "#6f8d41")},
            {2157,  new PantoneColor("378", "#566314")},
            {2158,  new PantoneColor("378 C", "#59611b")},
            {2159,  new PantoneColor("378 U", "#727a4d")},
            {2160,  new PantoneColor("379", "#e0ea68")},
            {2161,  new PantoneColor("379 C", "#e2e665")},
            {2162,  new PantoneColor("379 U", "#e6ec78")},
            {2163,  new PantoneColor("380", "#d6e542")},
            {2164,  new PantoneColor("380 C", "#dbe341")},
            {2165,  new PantoneColor("380 U", "#d3e257")},
            {2166,  new PantoneColor("381", "#cce226")},
            {2167,  new PantoneColor("381 C", "#cedb00")},
            {2168,  new PantoneColor("381 U", "#b8d537")},
            {2169,  new PantoneColor("382", "#bad80a")},
            {2170,  new PantoneColor("382 C", "#c3d500")},
            {2171,  new PantoneColor("382 U", "#98c11e")},
            {2172,  new PantoneColor("383", "#a3af07")},
            {2173,  new PantoneColor("383 C", "#aaad00")},
            {2174,  new PantoneColor("383 U", "#8d9935")},
            {2175,  new PantoneColor("384", "#939905")},
            {2176,  new PantoneColor("384 C", "#959300")},
            {2177,  new PantoneColor("384 U", "#878a3b")},
            {2178,  new PantoneColor("385", "#707014")},
            {2179,  new PantoneColor("385 C", "#79701f")},
            {2180,  new PantoneColor("385 U", "#7c794a")},
            {2181,  new PantoneColor("386", "#e8ed60")},
            {2182,  new PantoneColor("386 C", "#eceb6b")},
            {2183,  new PantoneColor("386 U", "#eef076")},
            {2184,  new PantoneColor("387", "#e0ed44")},
            {2185,  new PantoneColor("387 C", "#e3e733")},
            {2186,  new PantoneColor("387 U", "#e1ec52")},
            {2187,  new PantoneColor("388", "#d6e80f")},
            {2188,  new PantoneColor("388 C", "#e1e61e")},
            {2189,  new PantoneColor("388 U", "#d3e636")},
            {2190,  new PantoneColor("389", "#cee007")},
            {2191,  new PantoneColor("389 C", "#cede00")},
            {2192,  new PantoneColor("389 U", "#b9db00")},
            {2193,  new PantoneColor("390", "#bac405")},
            {2194,  new PantoneColor("390 C", "#b6bd00")},
            {2195,  new PantoneColor("390 U", "#94a824")},
            {2196,  new PantoneColor("391", "#9e9e07")},
            {2197,  new PantoneColor("391 C", "#9a9400")},
            {2198,  new PantoneColor("391 U", "#878a39")},
            {2199,  new PantoneColor("392", "#848205")},
            {2200,  new PantoneColor("392 C", "#837902")},
            {2201,  new PantoneColor("392 U", "#7f7c40")},
            {2202,  new PantoneColor("393", "#f2ef87")},
            {2203,  new PantoneColor("393 C", "#f1ec72")},
            {2204,  new PantoneColor("393 U", "#f7f182")},
            {2205,  new PantoneColor("3935", "#f2ed6d")},
            {2206,  new PantoneColor("3935 C", "#f5e85b")},
            {2207,  new PantoneColor("3935 U", "#fdf287")},
            {2208,  new PantoneColor("394", "#eaed35")},
            {2209,  new PantoneColor("394 C", "#eee838")},
            {2210,  new PantoneColor("394 U", "#f1ed55")},
            {2211,  new PantoneColor("3945", "#efea07")},
            {2212,  new PantoneColor("3945 C", "#f5e500")},
            {2213,  new PantoneColor("3945 U", "#fdef5c")},
            {2214,  new PantoneColor("395", "#e5e811")},
            {2215,  new PantoneColor("395 C", "#ece813")},
            {2216,  new PantoneColor("395 U", "#ebea3c")},
            {2217,  new PantoneColor("3955", "#ede211")},
            {2218,  new PantoneColor("3955 C", "#f2df00")},
            {2219,  new PantoneColor("3955 U", "#faea33")},
            {2220,  new PantoneColor("396", "#e0e20c")},
            {2221,  new PantoneColor("396 C", "#e1e000")},
            {2222,  new PantoneColor("396 U", "#d8e200")},
            {2223,  new PantoneColor("3965", "#e8dd11")},
            {2224,  new PantoneColor("3965 C", "#eedc00")},
            {2225,  new PantoneColor("3965 U", "#f8e709")},
            {2226,  new PantoneColor("397", "#c1bf0a")},
            {2227,  new PantoneColor("397 C", "#c0b800")},
            {2228,  new PantoneColor("397 U", "#a7a92e")},
            {2229,  new PantoneColor("3975", "#b5a80c")},
            {2230,  new PantoneColor("3975 C", "#bea600")},
            {2231,  new PantoneColor("3975 U", "#b7a62c")},
            {2232,  new PantoneColor("398", "#afa80a")},
            {2233,  new PantoneColor("398 C", "#ada300")},
            {2234,  new PantoneColor("398 U", "#969437")},
            {2235,  new PantoneColor("3985", "#998c0a")},
            {2236,  new PantoneColor("3985 C", "#9a8600")},
            {2237,  new PantoneColor("3985 U", "#9c8f3f")},
            {2238,  new PantoneColor("399", "#998e07")},
            {2239,  new PantoneColor("399 C", "#a29100")},
            {2240,  new PantoneColor("399 U", "#8a8537")},
            {2241,  new PantoneColor("3995", "#6d6002")},
            {2242,  new PantoneColor("3995 C", "#6a5c1f")},
            {2243,  new PantoneColor("3995 U", "#827a4a")},
            {2244,  new PantoneColor("400", "#d1c6b5")},
            {2245,  new PantoneColor("400 C", "#c6beb5")},
            {2246,  new PantoneColor("400 U", "#c7c0b9")},
            {2247,  new PantoneColor("401", "#c1b5a5")},
            {2248,  new PantoneColor("401 C", "#b1a99e")},
            {2249,  new PantoneColor("401 U", "#b4ada6")},
            {2250,  new PantoneColor("402", "#afa593")},
            {2251,  new PantoneColor("402 C", "#9e948b")},
            {2252,  new PantoneColor("402 U", "#a29c97")},
            {2253,  new PantoneColor("403", "#998c7c")},
            {2254,  new PantoneColor("403 C", "#8d837a")},
            {2255,  new PantoneColor("403 U", "#928c87")},
            {2256,  new PantoneColor("404", "#827566")},
            {2257,  new PantoneColor("404 C", "#776d63")},
            {2258,  new PantoneColor("404 U", "#8b8580")},
            {2259,  new PantoneColor("405", "#6b5e4f")},
            {2260,  new PantoneColor("405 C", "#696057")},
            {2261,  new PantoneColor("405 U", "#77716c")},
            {2262,  new PantoneColor("406", "#cec1b5")},
            {2263,  new PantoneColor("406 C", "#c7bbb5")},
            {2264,  new PantoneColor("406 U", "#c6beb9")},
            {2265,  new PantoneColor("407 C", "#b2a7a1")},
            {2266,  new PantoneColor("407 U", "#aba09e")},
            {2267,  new PantoneColor("408", "#a8998c")},
            {2268,  new PantoneColor("408 C", "#998b86")},
            {2269,  new PantoneColor("408 U", "#9d9494")},
            {2270,  new PantoneColor("409", "#99897c")},
            {2271,  new PantoneColor("409 C", "#877873")},
            {2272,  new PantoneColor("409 U", "#948a88")},
            {2273,  new PantoneColor("410", "#7c6d63")},
            {2274,  new PantoneColor("410 C", "#756660")},
            {2275,  new PantoneColor("410 U", "#8a817f")},
            {2276,  new PantoneColor("411", "#66594c")},
            {2277,  new PantoneColor("411 C", "#60504c")},
            {2278,  new PantoneColor("411 U", "#7a716f")},
            {2279,  new PantoneColor("412", "#3d3028")},
            {2280,  new PantoneColor("412 C", "#392e2c")},
            {2281,  new PantoneColor("412 U", "#645b59")},
            {2282,  new PantoneColor("413", "#c6c1b2")},
            {2283,  new PantoneColor("413 C", "#bbb9af")},
            {2284,  new PantoneColor("413 U", "#bbbcb3")},
            {2285,  new PantoneColor("414", "#b5afa0")},
            {2286,  new PantoneColor("414 C", "#aaa89e")},
            {2287,  new PantoneColor("414 U", "#a9aba4")},
            {2288,  new PantoneColor("415", "#a39e8c")},
            {2289,  new PantoneColor("415 C", "#929287")},
            {2290,  new PantoneColor("415 U", "#9c9e99")},
            {2291,  new PantoneColor("416", "#8e8c7a")},
            {2292,  new PantoneColor("416 C", "#7f7e73")},
            {2293,  new PantoneColor("416 U", "#8f918c")},
            {2294,  new PantoneColor("417", "#777263")},
            {2295,  new PantoneColor("417 C", "#66665c")},
            {2296,  new PantoneColor("417 U", "#81837d")},
            {2297,  new PantoneColor("418", "#605e4f")},
            {2298,  new PantoneColor("418 C", "#525249")},
            {2299,  new PantoneColor("418 U", "#787a75")},
            {2300,  new PantoneColor("419", "#282821")},
            {2301,  new PantoneColor("419 C", "#212221")},
            {2302,  new PantoneColor("419 U", "#585753")},
            {2303,  new PantoneColor("420", "#d1ccbf")},
            {2304,  new PantoneColor("420 C", "#c9c8c7")},
            {2305,  new PantoneColor("420 U", "#bdbdbc")},
            {2306,  new PantoneColor("421", "#bfbaaf")},
            {2307,  new PantoneColor("421 C", "#b2b3b2")},
            {2308,  new PantoneColor("421 U", "#b2b4b4")},
            {2309,  new PantoneColor("422", "#afaaa3")},
            {2310,  new PantoneColor("422 C", "#9fa1a1")},
            {2311,  new PantoneColor("422 U", "#9ea0a2")},
            {2312,  new PantoneColor("423", "#96938e")},
            {2313,  new PantoneColor("423 C", "#8a8b8c")},
            {2314,  new PantoneColor("423 U", "#909295")},
            {2315,  new PantoneColor("424", "#827f77")},
            {2316,  new PantoneColor("424 C", "#707170")},
            {2317,  new PantoneColor("424 U", "#878889")},
            {2318,  new PantoneColor("425", "#60605b")},
            {2319,  new PantoneColor("425 C", "#545759")},
            {2320,  new PantoneColor("425 U", "#7a7c7e")},
            {2321,  new PantoneColor("426", "#2b2b28")},
            {2322,  new PantoneColor("426 C", "#252729")},
            {2323,  new PantoneColor("426 U", "#686768")},
            {2324,  new PantoneColor("427", "#dddbd1")},
            {2325,  new PantoneColor("427 C", "#d0d2d3")},
            {2326,  new PantoneColor("427 U", "#c2c7c9")},
            {2327,  new PantoneColor("428", "#d1cec6")},
            {2328,  new PantoneColor("428 C", "#c3c5c8")},
            {2329,  new PantoneColor("428 U", "#acb2b8")},
            {2330,  new PantoneColor("429", "#adafaa")},
            {2331,  new PantoneColor("429 C", "#a3a9ac")},
            {2332,  new PantoneColor("429 U", "#90979e")},
            {2333,  new PantoneColor("430", "#919693")},
            {2334,  new PantoneColor("430 C", "#7c858c")},
            {2335,  new PantoneColor("430 U", "#7e888f")},
            {2336,  new PantoneColor("431", "#666d70")},
            {2337,  new PantoneColor("431 C", "#5c666f")},
            {2338,  new PantoneColor("431 U", "#737a82")},
            {2339,  new PantoneColor("432", "#444f51")},
            {2340,  new PantoneColor("432 C", "#333d47")},
            {2341,  new PantoneColor("432 U", "#656b72")},
            {2342,  new PantoneColor("433", "#30383a")},
            {2343,  new PantoneColor("433 C", "#1e242b")},
            {2344,  new PantoneColor("433 U", "#5b5c62")},
            {2345,  new PantoneColor("434", "#e0d1c6")},
            {2346,  new PantoneColor("434 C", "#d0c4c4")},
            {2347,  new PantoneColor("434 U", "#d3c9c9")},
            {2348,  new PantoneColor("435", "#d3bfb7")},
            {2349,  new PantoneColor("435 C", "#c0b2b5")},
            {2350,  new PantoneColor("435 U", "#b3a8ac")},
            {2351,  new PantoneColor("436", "#bca59e")},
            {2352,  new PantoneColor("436 C", "#aa989c")},
            {2353,  new PantoneColor("436 U", "#a89a9d")},
            {2354,  new PantoneColor("437", "#8c706b")},
            {2355,  new PantoneColor("437 C", "#7b6568")},
            {2356,  new PantoneColor("437 U", "#8c7f81")},
            {2357,  new PantoneColor("438", "#593f3d")},
            {2358,  new PantoneColor("438 C", "#584444")},
            {2359,  new PantoneColor("438 U", "#7f7273")},
            {2360,  new PantoneColor("439", "#493533")},
            {2361,  new PantoneColor("439 C", "#443634")},
            {2362,  new PantoneColor("439 U", "#726767")},
            {2363,  new PantoneColor("440", "#3f302b")},
            {2364,  new PantoneColor("440 C", "#382d2b")},
            {2365,  new PantoneColor("440 U", "#67605e")},
            {2366,  new PantoneColor("441", "#d1d1c6")},
            {2367,  new PantoneColor("441 C", "#bdc6c3")},
            {2368,  new PantoneColor("441 U", "#b6c2c0")},
            {2369,  new PantoneColor("442", "#babfb7")},
            {2370,  new PantoneColor("442 C", "#a0acaa")},
            {2371,  new PantoneColor("442 U", "#a9b5b5")},
            {2372,  new PantoneColor("443", "#a3a8a3")},
            {2373,  new PantoneColor("443 C", "#909c9c")},
            {2374,  new PantoneColor("443 U", "#8c999a")},
            {2375,  new PantoneColor("444", "#898e8c")},
            {2376,  new PantoneColor("444 C", "#707b7b")},
            {2377,  new PantoneColor("444 U", "#7c8688")},
            {2378,  new PantoneColor("445", "#565959")},
            {2379,  new PantoneColor("445 C", "#4e5758")},
            {2380,  new PantoneColor("445 U", "#687171")},
            {2381,  new PantoneColor("446", "#494c49")},
            {2382,  new PantoneColor("446 C", "#3d4542")},
            {2383,  new PantoneColor("446 U", "#626867")},
            {2384,  new PantoneColor("447", "#3f3f38")},
            {2385,  new PantoneColor("447 C", "#373935")},
            {2386,  new PantoneColor("447 U", "#5d605f")},
            {2387,  new PantoneColor("448", "#54472d")},
            {2388,  new PantoneColor("448 C", "#4c4028")},
            {2389,  new PantoneColor("448 U", "#67604e")},
            {2390,  new PantoneColor("4485", "#604c11")},
            {2391,  new PantoneColor("4485 C", "#634e25")},
            {2392,  new PantoneColor("4485 U", "#7b6e4b")},
            {2393,  new PantoneColor("449", "#544726")},
            {2394,  new PantoneColor("449 C", "#554525")},
            {2395,  new PantoneColor("449 U", "#706a52")},
            {2396,  new PantoneColor("4495", "#877530")},
            {2397,  new PantoneColor("4495 C", "#8e7630")},
            {2398,  new PantoneColor("4495 U", "#91825e")},
            {2399,  new PantoneColor("450", "#60542b")},
            {2400,  new PantoneColor("450 C", "#5c4925")},
            {2401,  new PantoneColor("450 U", "#807659")},
            {2402,  new PantoneColor("4505", "#a09151")},
            {2403,  new PantoneColor("4505 C", "#9b8442")},
            {2404,  new PantoneColor("4505 U", "#a39671")},
            {2405,  new PantoneColor("451", "#ada07a")},
            {2406,  new PantoneColor("451 C", "#9f915d")},
            {2407,  new PantoneColor("451 U", "#939072")},
            {2408,  new PantoneColor("4515", "#bcad75")},
            {2409,  new PantoneColor("4515 C", "#b5a268")},
            {2410,  new PantoneColor("4515 U", "#b1a47e")},
            {2411,  new PantoneColor("452", "#c4b796")},
            {2412,  new PantoneColor("452 C", "#b3a77d")},
            {2413,  new PantoneColor("452 U", "#a8a586")},
            {2414,  new PantoneColor("4525", "#ccbf8e")},
            {2415,  new PantoneColor("4525 C", "#c7b683")},
            {2416,  new PantoneColor("4525 U", "#c1b38b")},
            {2417,  new PantoneColor("453", "#d6ccaf")},
            {2418,  new PantoneColor("453 C", "#c3ba98")},
            {2419,  new PantoneColor("453 U", "#bdb798")},
            {2420,  new PantoneColor("4535", "#dbcea5")},
            {2421,  new PantoneColor("4535 C", "#d1c392")},
            {2422,  new PantoneColor("4535 U", "#cbbd94")},
            {2423,  new PantoneColor("454", "#e2d8bf")},
            {2424,  new PantoneColor("454 C", "#cdc4a6")},
            {2425,  new PantoneColor("454 U", "#cbc6ab")},
            {2426,  new PantoneColor("4545", "#e5dbba")},
            {2427,  new PantoneColor("4545 C", "#d6ca9e")},
            {2428,  new PantoneColor("4545 U", "#d6cba5")},
            {2429,  new PantoneColor("455", "#665614")},
            {2430,  new PantoneColor("455 C", "#6c5a23")},
            {2431,  new PantoneColor("455 U", "#776e48")},
            {2432,  new PantoneColor("456", "#998714")},
            {2433,  new PantoneColor("456 C", "#a58d28")},
            {2434,  new PantoneColor("456 U", "#918144")},
            {2435,  new PantoneColor("457", "#b59b0c")},
            {2436,  new PantoneColor("457 C", "#ba9c13")},
            {2437,  new PantoneColor("457 U", "#ad9641")},
            {2438,  new PantoneColor("458", "#ddcc6b")},
            {2439,  new PantoneColor("458 C", "#dbc554")},
            {2440,  new PantoneColor("458 U", "#cfb863")},
            {2441,  new PantoneColor("459", "#e2d67c")},
            {2442,  new PantoneColor("459 C", "#e0cc61")},
            {2443,  new PantoneColor("459 U", "#dfca76")},
            {2444,  new PantoneColor("460", "#eadd96")},
            {2445,  new PantoneColor("460 C", "#e7d67e")},
            {2446,  new PantoneColor("460 U", "#e9d789")},
            {2447,  new PantoneColor("461", "#ede5ad")},
            {2448,  new PantoneColor("461 C", "#ecde97")},
            {2449,  new PantoneColor("461 U", "#eee09d")},
            {2450,  new PantoneColor("462", "#5b4723")},
            {2451,  new PantoneColor("462 C", "#5e452a")},
            {2452,  new PantoneColor("462 U", "#70614c")},
            {2453,  new PantoneColor("4625", "#472311")},
            {2454,  new PantoneColor("4625 C", "#512b1c")},
            {2455,  new PantoneColor("4625 U", "#715744")},
            {2456,  new PantoneColor("463", "#755426")},
            {2457,  new PantoneColor("463 C", "#774d27")},
            {2458,  new PantoneColor("463 U", "#876d51")},
            {2459,  new PantoneColor("4635", "#8c5933")},
            {2460,  new PantoneColor("4635 C", "#975f35")},
            {2461,  new PantoneColor("4635 U", "#92705c")},
            {2462,  new PantoneColor("464", "#876028")},
            {2463,  new PantoneColor("464 C", "#8f5927")},
            {2464,  new PantoneColor("464 U", "#9e7b56")},
            {2465,  new PantoneColor("4645", "#b28260")},
            {2466,  new PantoneColor("4645 C", "#b07c57")},
            {2467,  new PantoneColor("4645 U", "#a17d6b")},
            {2468,  new PantoneColor("465", "#c1a875")},
            {2469,  new PantoneColor("465 C", "#bd955a")},
            {2470,  new PantoneColor("465 U", "#b2926f")},
            {2471,  new PantoneColor("4655", "#c49977")},
            {2472,  new PantoneColor("4655 C", "#c19372")},
            {2473,  new PantoneColor("4655 U", "#b28d7a")},
            {2474,  new PantoneColor("466", "#d1bf91")},
            {2475,  new PantoneColor("466 C", "#caa976")},
            {2476,  new PantoneColor("466 U", "#c4a480")},
            {2477,  new PantoneColor("4665", "#d8b596")},
            {2478,  new PantoneColor("4665 C", "#cea787")},
            {2479,  new PantoneColor("4665 U", "#caa48b")},
            {2480,  new PantoneColor("467", "#ddcca5")},
            {2481,  new PantoneColor("467 C", "#d6ba8b")},
            {2482,  new PantoneColor("467 U", "#d5b892")},
            {2483,  new PantoneColor("4675", "#e5c6aa")},
            {2484,  new PantoneColor("4675 C", "#debfa4")},
            {2485,  new PantoneColor("4675 U", "#dcb89f")},
            {2486,  new PantoneColor("468", "#e2d6b5")},
            {2487,  new PantoneColor("468 C", "#dfc9a2")},
            {2488,  new PantoneColor("468 U", "#e1cda9")},
            {2489,  new PantoneColor("4685", "#edd3bc")},
            {2490,  new PantoneColor("4685 C", "#e1c5ac")},
            {2491,  new PantoneColor("4685 U", "#e6cab3")},
            {2492,  new PantoneColor("469", "#603311")},
            {2493,  new PantoneColor("469 C", "#6b3f22")},
            {2494,  new PantoneColor("469 U", "#7b5f4a")},
            {2495,  new PantoneColor("4695", "#51261c")},
            {2496,  new PantoneColor("4695 C", "#5d3326")},
            {2497,  new PantoneColor("4695 U", "#775b4f")},
            {2498,  new PantoneColor("470", "#9b4f19")},
            {2499,  new PantoneColor("470 C", "#a75928")},
            {2500,  new PantoneColor("470 U", "#a56f51")},
            {2501,  new PantoneColor("4705", "#7c513d")},
            {2502,  new PantoneColor("4705 C", "#814c3a")},
            {2503,  new PantoneColor("4705 U", "#8b6e65")},
            {2504,  new PantoneColor("471", "#bc5e1e")},
            {2505,  new PantoneColor("471 C", "#bc6123")},
            {2506,  new PantoneColor("471 U", "#c17a52")},
            {2507,  new PantoneColor("4715", "#99705b")},
            {2508,  new PantoneColor("4715 C", "#996a57")},
            {2509,  new PantoneColor("4715 U", "#9b7c73")},
            {2510,  new PantoneColor("472", "#eaaa7a")},
            {2511,  new PantoneColor("472 C", "#e79d6c")},
            {2512,  new PantoneColor("472 U", "#dd926f")},
            {2513,  new PantoneColor("4725", "#b5917c")},
            {2514,  new PantoneColor("4725 C", "#b28877")},
            {2515,  new PantoneColor("4725 U", "#b09087")},
            {2516,  new PantoneColor("473", "#f4c4a0")},
            {2517,  new PantoneColor("473 C", "#f5be99")},
            {2518,  new PantoneColor("473 U", "#efab87")},
            {2519,  new PantoneColor("4735", "#ccaf9b")},
            {2520,  new PantoneColor("4735 C", "#c3a291")},
            {2521,  new PantoneColor("4735 U", "#bfa094")},
            {2522,  new PantoneColor("474", "#f4ccaa")},
            {2523,  new PantoneColor("474 C", "#f4c6a6")},
            {2524,  new PantoneColor("474 U", "#f7bd9b")},
            {2525,  new PantoneColor("4745", "#d8bfaa")},
            {2526,  new PantoneColor("4745 C", "#cfb4a7")},
            {2527,  new PantoneColor("4745 U", "#d0b3a8")},
            {2528,  new PantoneColor("475", "#f7d3b5")},
            {2529,  new PantoneColor("475 C", "#f4cfb2")},
            {2530,  new PantoneColor("475 U", "#fbcbab")},
            {2531,  new PantoneColor("4755", "#e2ccba")},
            {2532,  new PantoneColor("4755 C", "#dac2b6")},
            {2533,  new PantoneColor("4755 U", "#ddc5bb")},
            {2534,  new PantoneColor("476", "#593d2b")},
            {2535,  new PantoneColor("476 C", "#513528")},
            {2536,  new PantoneColor("476 U", "#6d5c50")},
            {2537,  new PantoneColor("477", "#633826")},
            {2538,  new PantoneColor("477 C", "#663a2a")},
            {2539,  new PantoneColor("477 U", "#7e6355")},
            {2540,  new PantoneColor("478", "#7a3f28")},
            {2541,  new PantoneColor("478 C", "#753d29")},
            {2542,  new PantoneColor("478 U", "#906d5b")},
            {2543,  new PantoneColor("479", "#af8970")},
            {2544,  new PantoneColor("479 C", "#ae7f65")},
            {2545,  new PantoneColor("479 U", "#ae8a7d")},
            {2546,  new PantoneColor("480", "#d3b7a3")},
            {2547,  new PantoneColor("480 C", "#c9a791")},
            {2548,  new PantoneColor("480 U", "#c5a292")},
            {2549,  new PantoneColor("481", "#e0ccba")},
            {2550,  new PantoneColor("481 C", "#d6b9a7")},
            {2551,  new PantoneColor("481 U", "#d6b5a6")},
            {2552,  new PantoneColor("482", "#e5d3c1")},
            {2553,  new PantoneColor("482 C", "#dec7b6")},
            {2554,  new PantoneColor("482 U", "#e0c6b6")},
            {2555,  new PantoneColor("483", "#6b3021")},
            {2556,  new PantoneColor("483 C", "#682f24")},
            {2557,  new PantoneColor("483 U", "#805a4e")},
            {2558,  new PantoneColor("484", "#9b301c")},
            {2559,  new PantoneColor("484 C", "#9f3122")},
            {2560,  new PantoneColor("484 U", "#a35a4d")},
            {2561,  new PantoneColor("485", "#d81e05")},
            {2562,  new PantoneColor("485 C", "#e2231a")},
            {2563,  new PantoneColor("485 U", "#ea5b4e")},
            {2564,  new PantoneColor("486", "#ed9e84")},
            {2565,  new PantoneColor("486 C", "#ef8f7a")},
            {2566,  new PantoneColor("486 U", "#f48a7f")},
            {2567,  new PantoneColor("487", "#efb5a0")},
            {2568,  new PantoneColor("487 C", "#f0a693")},
            {2569,  new PantoneColor("487 U", "#f7a192")},
            {2570,  new PantoneColor("488", "#f2c4af")},
            {2571,  new PantoneColor("488 C", "#f1b8a8")},
            {2572,  new PantoneColor("488 U", "#f7b7a7")},
            {2573,  new PantoneColor("489", "#f2d1bf")},
            {2574,  new PantoneColor("489 C", "#f0c2b2")},
            {2575,  new PantoneColor("489 U", "#f8c6b7")},
            {2576,  new PantoneColor("490", "#5b2626")},
            {2577,  new PantoneColor("490 C", "#5e292a")},
            {2578,  new PantoneColor("490 U", "#775552")},
            {2579,  new PantoneColor("491", "#752828")},
            {2580,  new PantoneColor("491 C", "#813033")},
            {2581,  new PantoneColor("491 U", "#8f5958")},
            {2582,  new PantoneColor("492", "#913338")},
            {2583,  new PantoneColor("492 C", "#933235")},
            {2584,  new PantoneColor("492 U", "#9d5e5e")},
            {2585,  new PantoneColor("493 C", "#de8797")},
            {2586,  new PantoneColor("493 U", "#c97c86")},
            {2587,  new PantoneColor("494", "#f2adb2")},
            {2588,  new PantoneColor("494 C", "#eca2b0")},
            {2589,  new PantoneColor("494 U", "#e59ba7")},
            {2590,  new PantoneColor("495", "#f4bcbf")},
            {2591,  new PantoneColor("495 C", "#f4bdc6")},
            {2592,  new PantoneColor("495 U", "#f3afba")},
            {2593,  new PantoneColor("496", "#f7c9c6")},
            {2594,  new PantoneColor("496 C", "#f4c6ce")},
            {2595,  new PantoneColor("496 U", "#fac2cb")},
            {2596,  new PantoneColor("497", "#512826")},
            {2597,  new PantoneColor("497 C", "#52302c")},
            {2598,  new PantoneColor("497 U", "#705854")},
            {2599,  new PantoneColor("4975", "#441e1c")},
            {2600,  new PantoneColor("4975 C", "#411f1f")},
            {2601,  new PantoneColor("4975 U", "#735553")},
            {2602,  new PantoneColor("498", "#6d332b")},
            {2603,  new PantoneColor("498 C", "#6a3833")},
            {2604,  new PantoneColor("498 U", "#805c5a")},
            {2605,  new PantoneColor("4985", "#844949")},
            {2606,  new PantoneColor("4985 C", "#894b51")},
            {2607,  new PantoneColor("4985 U", "#8f6a6d")},
            {2608,  new PantoneColor("499", "#7a382d")},
            {2609,  new PantoneColor("499 C", "#7a3f38")},
            {2610,  new PantoneColor("499 U", "#8c615d")},
            {2611,  new PantoneColor("4995", "#a56b6d")},
            {2612,  new PantoneColor("4995 C", "#9d6167")},
            {2613,  new PantoneColor("4995 U", "#a0787e")},
            {2614,  new PantoneColor("500", "#ce898c")},
            {2615,  new PantoneColor("500 C", "#c8868c")},
            {2616,  new PantoneColor("500 U", "#bd8a8e")},
            {2617,  new PantoneColor("5005", "#bc8787")},
            {2618,  new PantoneColor("5005 C", "#b27b80")},
            {2619,  new PantoneColor("5005 U", "#b28a8f")},
            {2620,  new PantoneColor("501", "#eab2b2")},
            {2621,  new PantoneColor("501 C", "#dca5ab")},
            {2622,  new PantoneColor("501 U", "#d8a5a9")},
            {2623,  new PantoneColor("5015", "#d8ada8")},
            {2624,  new PantoneColor("5015 C", "#cda1a5")},
            {2625,  new PantoneColor("5015 U", "#cba0a4")},
            {2626,  new PantoneColor("502", "#f2c6c4")},
            {2627,  new PantoneColor("502 C", "#e6bbc0")},
            {2628,  new PantoneColor("502 U", "#e5b7bb")},
            {2629,  new PantoneColor("5025", "#e2bcb7")},
            {2630,  new PantoneColor("5025 C", "#ddb7bb")},
            {2631,  new PantoneColor("5025 U", "#dcb6ba")},
            {2632,  new PantoneColor("503", "#f4d1cc")},
            {2633,  new PantoneColor("503 C", "#ebc4c6")},
            {2634,  new PantoneColor("503 U", "#f1cccd")},
            {2635,  new PantoneColor("5035", "#edcec6")},
            {2636,  new PantoneColor("5035 C", "#e1c2c1")},
            {2637,  new PantoneColor("5035 U", "#e6c6c6")},
            {2638,  new PantoneColor("504", "#511e26")},
            {2639,  new PantoneColor("504 C", "#572930")},
            {2640,  new PantoneColor("504 U", "#7f5c60")},
            {2641,  new PantoneColor("505", "#661e2b")},
            {2642,  new PantoneColor("505 C", "#702d3d")},
            {2643,  new PantoneColor("505 U", "#8b5c64")},
            {2644,  new PantoneColor("506", "#7a2638")},
            {2645,  new PantoneColor("506 C", "#87354c")},
            {2646,  new PantoneColor("506 U", "#9b6370")},
            {2647,  new PantoneColor("507", "#d8899b")},
            {2648,  new PantoneColor("507 C", "#d891a8")},
            {2649,  new PantoneColor("507 U", "#cf8ea1")},
            {2650,  new PantoneColor("508", "#e8a5af")},
            {2651,  new PantoneColor("508 C", "#e6a9b8")},
            {2652,  new PantoneColor("508 U", "#e09cac")},
            {2653,  new PantoneColor("509", "#f2babf")},
            {2654,  new PantoneColor("509 C", "#ebb3c3")},
            {2655,  new PantoneColor("509 U", "#ebaebd")},
            {2656,  new PantoneColor("510", "#f4c6c9")},
            {2657,  new PantoneColor("510 C", "#edbec8")},
            {2658,  new PantoneColor("510 U", "#f3bfcb")},
            {2659,  new PantoneColor("511", "#602144")},
            {2660,  new PantoneColor("511 C", "#632c4f")},
            {2661,  new PantoneColor("511 U", "#735567")},
            {2662,  new PantoneColor("5115", "#4f213a")},
            {2663,  new PantoneColor("5115 C", "#532943")},
            {2664,  new PantoneColor("5115 U", "#6f5462")},
            {2665,  new PantoneColor("512", "#84216b")},
            {2666,  new PantoneColor("512 C", "#853175")},
            {2667,  new PantoneColor("512 U", "#8a587e")},
            {2668,  new PantoneColor("5125", "#754760")},
            {2669,  new PantoneColor("5125 C", "#6d3a5d")},
            {2670,  new PantoneColor("5125 U", "#7e6276")},
            {2671,  new PantoneColor("513", "#9e2387")},
            {2672,  new PantoneColor("513 C", "#94348c")},
            {2673,  new PantoneColor("513 U", "#9e5f97")},
            {2674,  new PantoneColor("5135", "#936b7f")},
            {2675,  new PantoneColor("5135 C", "#815374")},
            {2676,  new PantoneColor("5135 U", "#8d7086")},
            {2677,  new PantoneColor("514", "#d884bc")},
            {2678,  new PantoneColor("514 C", "#d68bc6")},
            {2679,  new PantoneColor("514 U", "#d08ac1")},
            {2680,  new PantoneColor("5145", "#ad8799")},
            {2681,  new PantoneColor("5145 C", "#9e7691")},
            {2682,  new PantoneColor("5145 U", "#a5879e")},
            {2683,  new PantoneColor("515", "#e8a3c9")},
            {2684,  new PantoneColor("515 C", "#e4acd5")},
            {2685,  new PantoneColor("515 U", "#e2a5d4")},
            {2686,  new PantoneColor("5155", "#ccafb7")},
            {2687,  new PantoneColor("5155 C", "#c1a4b7")},
            {2688,  new PantoneColor("5155 U", "#b99db1")},
            {2689,  new PantoneColor("516", "#f2bad3")},
            {2690,  new PantoneColor("516 C", "#e9bedb")},
            {2691,  new PantoneColor("516 U", "#e8b6d9")},
            {2692,  new PantoneColor("5165", "#e0c9cc")},
            {2693,  new PantoneColor("5165 C", "#d4bfcc")},
            {2694,  new PantoneColor("5165 U", "#cdb3c3")},
            {2695,  new PantoneColor("517", "#f4ccd8")},
            {2696,  new PantoneColor("517 C", "#edc5de")},
            {2697,  new PantoneColor("517 U", "#f3c8e1")},
            {2698,  new PantoneColor("5175", "#e8d6d1")},
            {2699,  new PantoneColor("5175 C", "#dac6ce")},
            {2700,  new PantoneColor("5175 U", "#dbc4cf")},
            {2701,  new PantoneColor("518", "#512d44")},
            {2702,  new PantoneColor("518 C", "#4d2e47")},
            {2703,  new PantoneColor("518 U", "#6d5968")},
            {2704,  new PantoneColor("5185", "#472835")},
            {2705,  new PantoneColor("5185 C", "#4c3040")},
            {2706,  new PantoneColor("5185 U", "#746068")},
            {2707,  new PantoneColor("519", "#63305e")},
            {2708,  new PantoneColor("519 C", "#5b305d")},
            {2709,  new PantoneColor("519 U", "#785d7b")},
            {2710,  new PantoneColor("5195", "#593344")},
            {2711,  new PantoneColor("5195 C", "#684458")},
            {2712,  new PantoneColor("5195 U", "#816b77")},
            {2713,  new PantoneColor("520", "#703572")},
            {2714,  new PantoneColor("520 C", "#662e6b")},
            {2715,  new PantoneColor("520 U", "#825e86")},
            {2716,  new PantoneColor("5205", "#8e6877")},
            {2717,  new PantoneColor("5205 C", "#886378")},
            {2718,  new PantoneColor("5205 U", "#907b89")},
            {2719,  new PantoneColor("521", "#b58cb2")},
            {2720,  new PantoneColor("521 C", "#a87eb1")},
            {2721,  new PantoneColor("521 U", "#aa89b4")},
            {2722,  new PantoneColor("5215", "#b5939b")},
            {2723,  new PantoneColor("5215 C", "#b095a5")},
            {2724,  new PantoneColor("5215 U", "#a28c9a")},
            {2725,  new PantoneColor("522", "#c6a3c1")},
            {2726,  new PantoneColor("522 C", "#bd9bc4")},
            {2727,  new PantoneColor("522 U", "#be9dc5")},
            {2728,  new PantoneColor("5225", "#ccadaf")},
            {2729,  new PantoneColor("5225 C", "#c8afbb")},
            {2730,  new PantoneColor("5225 U", "#c3abb8")},
            {2731,  new PantoneColor("523", "#d3b7cc")},
            {2732,  new PantoneColor("523 C", "#ccb0cf")},
            {2733,  new PantoneColor("523 U", "#d2b5d4")},
            {2734,  new PantoneColor("5235", "#ddc6c4")},
            {2735,  new PantoneColor("5235 C", "#d2bdc6")},
            {2736,  new PantoneColor("5235 U", "#d6c2ca")},
            {2737,  new PantoneColor("524", "#e2ccd3")},
            {2738,  new PantoneColor("524 C", "#d7c2d6")},
            {2739,  new PantoneColor("524 U", "#dcc4dc")},
            {2740,  new PantoneColor("5245", "#e5d3cc")},
            {2741,  new PantoneColor("5245 C", "#ddcdd2")},
            {2742,  new PantoneColor("5245 U", "#dfcfd4")},
            {2743,  new PantoneColor("525", "#512654")},
            {2744,  new PantoneColor("525 C", "#592b5e")},
            {2745,  new PantoneColor("525 U", "#735675")},
            {2746,  new PantoneColor("5255", "#35264f")},
            {2747,  new PantoneColor("5255 C", "#1e1933")},
            {2748,  new PantoneColor("5255 U", "#5d566c")},
            {2749,  new PantoneColor("526", "#68217a")},
            {2750,  new PantoneColor("526 C", "#742f8a")},
            {2751,  new PantoneColor("526 U", "#815790")},
            {2752,  new PantoneColor("5265", "#493d63")},
            {2753,  new PantoneColor("5265 C", "#40395f")},
            {2754,  new PantoneColor("5265 U", "#6e6a81")},
            {2755,  new PantoneColor("527", "#7a1e99")},
            {2756,  new PantoneColor("527 C", "#8430a6")},
            {2757,  new PantoneColor("527 U", "#945fae")},
            {2758,  new PantoneColor("5275", "#605677")},
            {2759,  new PantoneColor("5275 C", "#5a5377")},
            {2760,  new PantoneColor("5275 U", "#797891")},
            {2761,  new PantoneColor("528", "#af72c1")},
            {2762,  new PantoneColor("528 C", "#ba80d0")},
            {2763,  new PantoneColor("528 U", "#ba88d2")},
            {2764,  new PantoneColor("5285", "#8c8299")},
            {2765,  new PantoneColor("5285 C", "#8e88a3")},
            {2766,  new PantoneColor("5285 U", "#9593ab")},
            {2767,  new PantoneColor("529", "#cea3d3")},
            {2768,  new PantoneColor("529 C", "#cea1dc")},
            {2769,  new PantoneColor("529 U", "#cfa3e0")},
            {2770,  new PantoneColor("5295", "#b2a8b5")},
            {2771,  new PantoneColor("5295 C", "#b4afc3")},
            {2772,  new PantoneColor("5295 U", "#b1adc3")},
            {2773,  new PantoneColor("530", "#d6afd6")},
            {2774,  new PantoneColor("530 C", "#dab7e2")},
            {2775,  new PantoneColor("530 U", "#dcb8e7")},
            {2776,  new PantoneColor("5305", "#ccc1c6")},
            {2777,  new PantoneColor("5305 C", "#c7c3d1")},
            {2778,  new PantoneColor("5305 U", "#c4c1d1")},
            {2779,  new PantoneColor("531", "#e5c6db")},
            {2780,  new PantoneColor("531 C", "#e2c7e6")},
            {2781,  new PantoneColor("531 U", "#e4c6ea")},
            {2782,  new PantoneColor("5315", "#dbd3d3")},
            {2783,  new PantoneColor("5315 C", "#dad6de")},
            {2784,  new PantoneColor("5315 U", "#dad7e1")},
            {2785,  new PantoneColor("532", "#353842")},
            {2786,  new PantoneColor("532 C", "#1c1e29")},
            {2787,  new PantoneColor("532 U", "#5b5a62")},
            {2788,  new PantoneColor("533", "#353f5b")},
            {2789,  new PantoneColor("533 C", "#212844")},
            {2790,  new PantoneColor("533 U", "#5e6378")},
            {2791,  new PantoneColor("534", "#3a4972")},
            {2792,  new PantoneColor("534 C", "#1e345d")},
            {2793,  new PantoneColor("534 U", "#5a6783")},
            {2794,  new PantoneColor("535", "#9ba3b7")},
            {2795,  new PantoneColor("535 C", "#8e9ebc")},
            {2796,  new PantoneColor("535 U", "#8b9cb8")},
            {2797,  new PantoneColor("536", "#adb2c1")},
            {2798,  new PantoneColor("536 C", "#a2b1c8")},
            {2799,  new PantoneColor("536 U", "#a2b4ca")},
            {2800,  new PantoneColor("537", "#c4c6ce")},
            {2801,  new PantoneColor("537 C", "#bbc6d6")},
            {2802,  new PantoneColor("537 U", "#bbc9d9")},
            {2803,  new PantoneColor("538", "#d6d3d6")},
            {2804,  new PantoneColor("538 C", "#c6cfda")},
            {2805,  new PantoneColor("538 U", "#ccd5e0")},
            {2806,  new PantoneColor("539", "#003049")},
            {2807,  new PantoneColor("539 C", "#002539")},
            {2808,  new PantoneColor("539 U", "#455063")},
            {2809,  new PantoneColor("5395", "#02283a")},
            {2810,  new PantoneColor("5395 C", "#0a1e2c")},
            {2811,  new PantoneColor("5395 U", "#464a58")},
            {2812,  new PantoneColor("540", "#00335b")},
            {2813,  new PantoneColor("540 C", "#002f56")},
            {2814,  new PantoneColor("540 U", "#3f506e")},
            {2815,  new PantoneColor("5405", "#3f6075")},
            {2816,  new PantoneColor("5405 C", "#4f738a")},
            {2817,  new PantoneColor("5405 U", "#596e80")},
            {2818,  new PantoneColor("541", "#003f77")},
            {2819,  new PantoneColor("541 C", "#003b70")},
            {2820,  new PantoneColor("541 U", "#38547a")},
            {2821,  new PantoneColor("5415", "#607c8c")},
            {2822,  new PantoneColor("5415 C", "#5d7e95")},
            {2823,  new PantoneColor("5415 U", "#657d91")},
            {2824,  new PantoneColor("542", "#6693bc")},
            {2825,  new PantoneColor("542 C", "#7cadd3")},
            {2826,  new PantoneColor("542 U", "#679ac6")},
            {2827,  new PantoneColor("5425", "#8499a5")},
            {2828,  new PantoneColor("5425 C", "#7c97ab")},
            {2829,  new PantoneColor("5425 U", "#7891a4")},
            {2830,  new PantoneColor("543", "#93b7d1")},
            {2831,  new PantoneColor("543 C", "#a4c7e2")},
            {2832,  new PantoneColor("543 U", "#78a9d2")},
            {2833,  new PantoneColor("5435", "#afbcbf")},
            {2834,  new PantoneColor("5435 C", "#a7bac8")},
            {2835,  new PantoneColor("5435 U", "#9cb3c4")},
            {2836,  new PantoneColor("544", "#b7ccdb")},
            {2837,  new PantoneColor("544 C", "#bfd4e6")},
            {2838,  new PantoneColor("544 U", "#96bfde")},
            {2839,  new PantoneColor("5445", "#c4cccc")},
            {2840,  new PantoneColor("5445 C", "#b8c7d3")},
            {2841,  new PantoneColor("5445 U", "#b3c6d2")},
            {2842,  new PantoneColor("545", "#c4d3dd")},
            {2843,  new PantoneColor("545 C", "#c7d9e6")},
            {2844,  new PantoneColor("545 U", "#accde5")},
            {2845,  new PantoneColor("5455", "#d6d8d3")},
            {2846,  new PantoneColor("5455 C", "#bfcdd4")},
            {2847,  new PantoneColor("5455 U", "#c7d5df")},
            {2848,  new PantoneColor("546", "#0c3844")},
            {2849,  new PantoneColor("546 C", "#08292f")},
            {2850,  new PantoneColor("546 U", "#444e57")},
            {2851,  new PantoneColor("5463", "#00353a")},
            {2852,  new PantoneColor("5463 C", "#08262c")},
            {2853,  new PantoneColor("5463 U", "#3d4d56")},
            {2854,  new PantoneColor("5467", "#193833")},
            {2855,  new PantoneColor("5467 C", "#1a322e")},
            {2856,  new PantoneColor("5467 U", "#535e5e")},
            {2857,  new PantoneColor("547", "#003f54")},
            {2858,  new PantoneColor("547 C", "#002f3b")},
            {2859,  new PantoneColor("547 U", "#415766")},
            {2860,  new PantoneColor("5473", "#26686d")},
            {2861,  new PantoneColor("5473 C", "#095c66")},
            {2862,  new PantoneColor("5473 U", "#4f6c75")},
            {2863,  new PantoneColor("5477", "#3a564f")},
            {2864,  new PantoneColor("5477 C", "#3f5b57")},
            {2865,  new PantoneColor("5477 U", "#5e6f6f")},
            {2866,  new PantoneColor("548", "#004459")},
            {2867,  new PantoneColor("548 C", "#003b4c")},
            {2868,  new PantoneColor("548 U", "#3e5c6f")},
            {2869,  new PantoneColor("5483", "#609191")},
            {2870,  new PantoneColor("5483 C", "#4d858d")},
            {2871,  new PantoneColor("5483 U", "#5c8088")},
            {2872,  new PantoneColor("5487", "#667c72")},
            {2873,  new PantoneColor("5487 C", "#5f7774")},
            {2874,  new PantoneColor("5487 U", "#687b7d")},
            {2875,  new PantoneColor("549", "#5e99aa")},
            {2876,  new PantoneColor("549 C", "#6aa2b8")},
            {2877,  new PantoneColor("549 U", "#6797ad")},
            {2878,  new PantoneColor("5493", "#8cafad")},
            {2879,  new PantoneColor("5493 C", "#7ea7ac")},
            {2880,  new PantoneColor("5493 U", "#739aa2")},
            {2881,  new PantoneColor("5497", "#91a399")},
            {2882,  new PantoneColor("5497 C", "#849794")},
            {2883,  new PantoneColor("5497 U", "#819393")},
            {2884,  new PantoneColor("550", "#87afbf")},
            {2885,  new PantoneColor("550 C", "#8db7c9")},
            {2886,  new PantoneColor("550 U", "#78a8be")},
            {2887,  new PantoneColor("5503", "#aac4bf")},
            {2888,  new PantoneColor("5503 C", "#93b6bb")},
            {2889,  new PantoneColor("5503 U", "#91b5bb")},
            {2890,  new PantoneColor("5507", "#afbab2")},
            {2891,  new PantoneColor("5507 C", "#9daeab")},
            {2892,  new PantoneColor("5507 U", "#96a7a6")},
            {2893,  new PantoneColor("551", "#a3c1c9")},
            {2894,  new PantoneColor("551 C", "#a4c5d2")},
            {2895,  new PantoneColor("551 U", "#95becd")},
            {2896,  new PantoneColor("5513", "#ced8d1")},
            {2897,  new PantoneColor("5513 C", "#acc6c8")},
            {2898,  new PantoneColor("5513 U", "#abc8cc")},
            {2899,  new PantoneColor("5517", "#c9cec4")},
            {2900,  new PantoneColor("5517 C", "#b2bfbb")},
            {2901,  new PantoneColor("5517 U", "#a7b8b7")},
            {2902,  new PantoneColor("552", "#c4d6d6")},
            {2903,  new PantoneColor("552 C", "#bbd2db")},
            {2904,  new PantoneColor("552 U", "#aecddb")},
            {2905,  new PantoneColor("5523", "#d6ddd6")},
            {2906,  new PantoneColor("5523 C", "#b7cecf")},
            {2907,  new PantoneColor("5523 U", "#bbd4d5")},
            {2908,  new PantoneColor("5527", "#ced1c6")},
            {2909,  new PantoneColor("5527 C", "#bcc7c4")},
            {2910,  new PantoneColor("5527 U", "#b7c6c3")},
            {2911,  new PantoneColor("553", "#234435")},
            {2912,  new PantoneColor("553 C", "#2a4633")},
            {2913,  new PantoneColor("553 U", "#59675c")},
            {2914,  new PantoneColor("5535", "#213d30")},
            {2915,  new PantoneColor("5535 C", "#172f28")},
            {2916,  new PantoneColor("5535 U", "#475855")},
            {2917,  new PantoneColor("554", "#195e47")},
            {2918,  new PantoneColor("554 C", "#225a40")},
            {2919,  new PantoneColor("554 U", "#567465")},
            {2920,  new PantoneColor("5545", "#4f6d5e")},
            {2921,  new PantoneColor("5545 C", "#43685a")},
            {2922,  new PantoneColor("5545 U", "#5f756f")},
            {2923,  new PantoneColor("555", "#076d54")},
            {2924,  new PantoneColor("555 C", "#2c704f")},
            {2925,  new PantoneColor("555 U", "#557c6a")},
            {2926,  new PantoneColor("5555", "#779182")},
            {2927,  new PantoneColor("5555 C", "#5b7f70")},
            {2928,  new PantoneColor("5555 U", "#738c86")},
            {2929,  new PantoneColor("556", "#7aa891")},
            {2930,  new PantoneColor("556 C", "#70a087")},
            {2931,  new PantoneColor("556 U", "#719b8b")},
            {2932,  new PantoneColor("5565", "#96aa99")},
            {2933,  new PantoneColor("5565 C", "#7e9c90")},
            {2934,  new PantoneColor("5565 U", "#87a19a")},
            {2935,  new PantoneColor("557", "#a3c1ad")},
            {2936,  new PantoneColor("557 C", "#87af99")},
            {2937,  new PantoneColor("557 U", "#88b09e")},
            {2938,  new PantoneColor("5575", "#afbfad")},
            {2939,  new PantoneColor("5575 C", "#92aba0")},
            {2940,  new PantoneColor("5575 U", "#9bb3aa")},
            {2941,  new PantoneColor("558", "#b7cebc")},
            {2942,  new PantoneColor("558 C", "#9bbdaa")},
            {2943,  new PantoneColor("558 U", "#99bead")},
            {2944,  new PantoneColor("5585", "#c4cebf")},
            {2945,  new PantoneColor("5585 C", "#a6bcb0")},
            {2946,  new PantoneColor("5585 U", "#a1b8af")},
            {2947,  new PantoneColor("559", "#c6d6c4")},
            {2948,  new PantoneColor("559 C", "#afc9b8")},
            {2949,  new PantoneColor("559 U", "#b5d0c0")},
            {2950,  new PantoneColor("5595", "#d8dbcc")},
            {2951,  new PantoneColor("5595 C", "#becdc2")},
            {2952,  new PantoneColor("5595 U", "#bfd1c7")},
            {2953,  new PantoneColor("560", "#2b4c3f")},
            {2954,  new PantoneColor("560 C", "#1b3c33")},
            {2955,  new PantoneColor("560 U", "#495d5b")},
            {2956,  new PantoneColor("5605", "#233a2d")},
            {2957,  new PantoneColor("5605 C", "#22362a")},
            {2958,  new PantoneColor("5605 U", "#5e685e")},
            {2959,  new PantoneColor("561", "#266659")},
            {2960,  new PantoneColor("561 C", "#00584d")},
            {2961,  new PantoneColor("561 U", "#446c68")},
            {2962,  new PantoneColor("5615", "#546856")},
            {2963,  new PantoneColor("5615 C", "#5e7260")},
            {2964,  new PantoneColor("5615 U", "#6a776f")},
            {2965,  new PantoneColor("562", "#1e7a6d")},
            {2966,  new PantoneColor("562 C", "#006e62")},
            {2967,  new PantoneColor("562 U", "#3e7f7b")},
            {2968,  new PantoneColor("5625", "#728470")},
            {2969,  new PantoneColor("5625 C", "#728472")},
            {2970,  new PantoneColor("5625 U", "#79877f")},
            {2971,  new PantoneColor("563", "#7fbcaa")},
            {2972,  new PantoneColor("563 C", "#67baaf")},
            {2973,  new PantoneColor("563 U", "#71b8b0")},
            {2974,  new PantoneColor("5635", "#9eaa99")},
            {2975,  new PantoneColor("5635 C", "#95a495")},
            {2976,  new PantoneColor("5635 U", "#8d9c94")},
            {2977,  new PantoneColor("564", "#05705e")},
            {2978,  new PantoneColor("564 C", "#82c7bc")},
            {2979,  new PantoneColor("564 U", "#82c5bb")},
            {2980,  new PantoneColor("5645", "#bcc1b2")},
            {2981,  new PantoneColor("5645 C", "#a4b1a3")},
            {2982,  new PantoneColor("5645 U", "#9faea5")},
            {2983,  new PantoneColor("565", "#bcdbcc")},
            {2984,  new PantoneColor("565 C", "#9fd4c9")},
            {2985,  new PantoneColor("565 U", "#8dd0c4")},
            {2986,  new PantoneColor("5655", "#c6ccba")},
            {2987,  new PantoneColor("5655 C", "#b2bcaf")},
            {2988,  new PantoneColor("5655 U", "#b3beb4")},
            {2989,  new PantoneColor("566", "#d1e2d3")},
            {2990,  new PantoneColor("566 C", "#b7dbd1")},
            {2991,  new PantoneColor("566 U", "#b0e0d6")},
            {2992,  new PantoneColor("5665", "#d6d6c6")},
            {2993,  new PantoneColor("5665 C", "#bcc4b9")},
            {2994,  new PantoneColor("5665 U", "#bac6bc")},
            {2995,  new PantoneColor("567", "#265142")},
            {2996,  new PantoneColor("567 C", "#163d34")},
            {2997,  new PantoneColor("567 U", "#49625d")},
            {2998,  new PantoneColor("568 C", "#006a5a")},
            {2999,  new PantoneColor("568 U", "#427f76")},
            {3000,  new PantoneColor("569", "#008772")},
            {3001,  new PantoneColor("569 C", "#007f6d")},
            {3002,  new PantoneColor("569 U", "#238d81")},
            {3003,  new PantoneColor("570", "#7fc6b2")},
            {3004,  new PantoneColor("570 C", "#69c9b9")},
            {3005,  new PantoneColor("570 U", "#5bc1b3")},
            {3006,  new PantoneColor("571", "#aadbc6")},
            {3007,  new PantoneColor("571 C", "#94dace")},
            {3008,  new PantoneColor("571 U", "#80d6c7")},
            {3009,  new PantoneColor("572", "#bce2ce")},
            {3010,  new PantoneColor("572 C", "#a2ded2")},
            {3011,  new PantoneColor("572 U", "#90dccf")},
            {3012,  new PantoneColor("573", "#cce5d6")},
            {3013,  new PantoneColor("573 C", "#b4e1d8")},
            {3014,  new PantoneColor("573 U", "#b8e8de")},
            {3015,  new PantoneColor("574", "#495928")},
            {3016,  new PantoneColor("574 C", "#4e5a30")},
            {3017,  new PantoneColor("574 U", "#697155")},
            {3018,  new PantoneColor("5743", "#3f4926")},
            {3019,  new PantoneColor("5743 C", "#404726")},
            {3020,  new PantoneColor("5743 U", "#636951")},
            {3021,  new PantoneColor("5747", "#424716")},
            {3022,  new PantoneColor("5747 C", "#3e431c")},
            {3023,  new PantoneColor("5747 U", "#6f734d")},
            {3024,  new PantoneColor("575", "#547730")},
            {3025,  new PantoneColor("575 C", "#69813a")},
            {3026,  new PantoneColor("575 U", "#6f8256")},
            {3027,  new PantoneColor("5753", "#5e663a")},
            {3028,  new PantoneColor("5753 C", "#606637")},
            {3029,  new PantoneColor("5753 U", "#747b60")},
            {3030,  new PantoneColor("5757", "#6b702b")},
            {3031,  new PantoneColor("5757 C", "#6c702d")},
            {3032,  new PantoneColor("5757 U", "#80845b")},
            {3033,  new PantoneColor("576", "#608e3a")},
            {3034,  new PantoneColor("576 C", "#7a9b49")},
            {3035,  new PantoneColor("576 U", "#7b9961")},
            {3036,  new PantoneColor("5763", "#777c4f")},
            {3037,  new PantoneColor("5763 C", "#767a4c")},
            {3038,  new PantoneColor("5763 U", "#7d856c")},
            {3039,  new PantoneColor("5767", "#8c914f")},
            {3040,  new PantoneColor("5767 C", "#8c8c48")},
            {3041,  new PantoneColor("5767 U", "#93966b")},
            {3042,  new PantoneColor("577", "#b5cc8e")},
            {3043,  new PantoneColor("577 C", "#abc27e")},
            {3044,  new PantoneColor("577 U", "#93b279")},
            {3045,  new PantoneColor("5773", "#9b9e72")},
            {3046,  new PantoneColor("5773 C", "#8a8f64")},
            {3047,  new PantoneColor("5773 U", "#98a084")},
            {3048,  new PantoneColor("5777", "#aaad75")},
            {3049,  new PantoneColor("5777 C", "#a2a467")},
            {3050,  new PantoneColor("5777 U", "#a5a87a")},
            {3051,  new PantoneColor("578", "#c6d6a0")},
            {3052,  new PantoneColor("578 C", "#b8cd95")},
            {3053,  new PantoneColor("578 U", "#a7c28d")},
            {3054,  new PantoneColor("5783", "#b5b58e")},
            {3055,  new PantoneColor("5783 C", "#a4a982")},
            {3056,  new PantoneColor("5783 U", "#b4b99e")},
            {3057,  new PantoneColor("5787", "#c6c699")},
            {3058,  new PantoneColor("5787 C", "#babc89")},
            {3059,  new PantoneColor("5787 U", "#babd90")},
            {3060,  new PantoneColor("579", "#c9d6a3")},
            {3061,  new PantoneColor("579 C", "#bfcf9a")},
            {3062,  new PantoneColor("579 U", "#b9cf9d")},
            {3063,  new PantoneColor("5793", "#c6c6a5")},
            {3064,  new PantoneColor("5793 C", "#b4b794")},
            {3065,  new PantoneColor("5793 U", "#c5c8ae")},
            {3066,  new PantoneColor("5797", "#d3d1aa")},
            {3067,  new PantoneColor("5797 C", "#c7c79a")},
            {3068,  new PantoneColor("5797 U", "#c6c99b")},
            {3069,  new PantoneColor("580", "#d8ddb5")},
            {3070,  new PantoneColor("580 C", "#c5d4a3")},
            {3071,  new PantoneColor("580 U", "#cadaac")},
            {3072,  new PantoneColor("5803", "#d8d6b7")},
            {3073,  new PantoneColor("5803 C", "#c4c6a6")},
            {3074,  new PantoneColor("5803 U", "#d0d1b8")},
            {3075,  new PantoneColor("5807", "#e0ddbc")},
            {3076,  new PantoneColor("5807 C", "#d1d0a9")},
            {3077,  new PantoneColor("5807 U", "#d1d2a9")},
            {3078,  new PantoneColor("581", "#605e11")},
            {3079,  new PantoneColor("581 C", "#645c20")},
            {3080,  new PantoneColor("581 U", "#787449")},
            {3081,  new PantoneColor("5815", "#494411")},
            {3082,  new PantoneColor("5815 C", "#564f23")},
            {3083,  new PantoneColor("5815 U", "#726e4a")},
            {3084,  new PantoneColor("582", "#878905")},
            {3085,  new PantoneColor("582 C", "#918c10")},
            {3086,  new PantoneColor("582 U", "#919044")},
            {3087,  new PantoneColor("5825", "#75702b")},
            {3088,  new PantoneColor("5825 C", "#8b803a")},
            {3089,  new PantoneColor("5825 U", "#8a855c")},
            {3090,  new PantoneColor("583", "#aaba0a")},
            {3091,  new PantoneColor("583 C", "#b9be10")},
            {3092,  new PantoneColor("583 U", "#a5b13e")},
            {3093,  new PantoneColor("5835", "#9e9959")},
            {3094,  new PantoneColor("5835 C", "#a19856")},
            {3095,  new PantoneColor("5835 U", "#948e65")},
            {3096,  new PantoneColor("584", "#ced649")},
            {3097,  new PantoneColor("584 C", "#d5d654")},
            {3098,  new PantoneColor("584 U", "#ced564")},
            {3099,  new PantoneColor("5845", "#b2aa70")},
            {3100,  new PantoneColor("5845 C", "#b1a96e")},
            {3101,  new PantoneColor("5845 U", "#a7a274")},
            {3102,  new PantoneColor("585", "#dbe06b")},
            {3103,  new PantoneColor("585 C", "#dedd6e")},
            {3104,  new PantoneColor("585 U", "#e3e584")},
            {3105,  new PantoneColor("5855", "#ccc693")},
            {3106,  new PantoneColor("5855 C", "#c1ba85")},
            {3107,  new PantoneColor("5855 U", "#bcb788")},
            {3108,  new PantoneColor("586", "#e2e584")},
            {3109,  new PantoneColor("586 C", "#e3e17b")},
            {3110,  new PantoneColor("586 U", "#e6e786")},
            {3111,  new PantoneColor("5865", "#d6cea3")},
            {3112,  new PantoneColor("5865 U", "#cec794")},
            {3113,  new PantoneColor("587", "#e8e89b")},
            {3114,  new PantoneColor("587 C", "#e5e38c")},
            {3115,  new PantoneColor("587 U", "#eceb97")},
            {3116,  new PantoneColor("5875", "#e0dbb5")},
            {3117,  new PantoneColor("5875 C", "#d5cd9e")},
            {3118,  new PantoneColor("5875 U", "#d7d19f")},
            {3119,  new PantoneColor("600", "#f4edaf")},
            {3120,  new PantoneColor("600 C", "#f2ea9a")},
            {3121,  new PantoneColor("600 U", "#faf19b")},
            {3122,  new PantoneColor("601", "#f2ed9e")},
            {3123,  new PantoneColor("601 C", "#f2e88e")},
            {3124,  new PantoneColor("601 U", "#f7ee8d")},
            {3125,  new PantoneColor("602", "#f2ea87")},
            {3126,  new PantoneColor("602 C", "#f2e77a")},
            {3127,  new PantoneColor("602 U", "#f7ec81")},
            {3128,  new PantoneColor("603", "#ede85b")},
            {3129,  new PantoneColor("603 C", "#efe048")},
            {3130,  new PantoneColor("603 U", "#f4e461")},
            {3131,  new PantoneColor("604", "#e8dd21")},
            {3132,  new PantoneColor("604 C", "#edda22")},
            {3133,  new PantoneColor("604 U", "#eeda4c")},
            {3134,  new PantoneColor("605", "#ddce11")},
            {3135,  new PantoneColor("605 C", "#e2cc00")},
            {3136,  new PantoneColor("605 U", "#e1cb38")},
            {3137,  new PantoneColor("606", "#d3bf11")},
            {3138,  new PantoneColor("606 C", "#d1b400")},
            {3139,  new PantoneColor("606 U", "#cfb724")},
            {3140,  new PantoneColor("607", "#f2eabc")},
            {3141,  new PantoneColor("607 C", "#ede499")},
            {3142,  new PantoneColor("607 U", "#f3e9a1")},
            {3143,  new PantoneColor("608", "#efe8ad")},
            {3144,  new PantoneColor("608 C", "#eae085")},
            {3145,  new PantoneColor("608 U", "#f0e590")},
            {3146,  new PantoneColor("609", "#eae596")},
            {3147,  new PantoneColor("609 C", "#e9dc75")},
            {3148,  new PantoneColor("609 U", "#ebde80")},
            {3149,  new PantoneColor("610", "#e2db72")},
            {3150,  new PantoneColor("610 C", "#e2d354")},
            {3151,  new PantoneColor("610 U", "#dfd166")},
            {3152,  new PantoneColor("611", "#d6ce49")},
            {3153,  new PantoneColor("611 C", "#d8c722")},
            {3154,  new PantoneColor("611 U", "#c8b84e")},
            {3155,  new PantoneColor("612", "#c4ba00")},
            {3156,  new PantoneColor("612 C", "#c7b000")},
            {3157,  new PantoneColor("612 U", "#b7a63e")},
            {3158,  new PantoneColor("613", "#afa00c")},
            {3159,  new PantoneColor("613 C", "#b59a00")},
            {3160,  new PantoneColor("613 U", "#a29335")},
            {3161,  new PantoneColor("614", "#eae2b7")},
            {3162,  new PantoneColor("614 C", "#ddd498")},
            {3163,  new PantoneColor("614 U", "#e2d8a1")},
            {3164,  new PantoneColor("615", "#e2dbaa")},
            {3165,  new PantoneColor("615 C", "#d7cd8c")},
            {3166,  new PantoneColor("615 U", "#dacf94")},
            {3167,  new PantoneColor("616", "#ddd69b")},
            {3168,  new PantoneColor("616 C", "#d2c780")},
            {3169,  new PantoneColor("616 U", "#cec387")},
            {3170,  new PantoneColor("617", "#ccc47c")},
            {3171,  new PantoneColor("617 C", "#c1b45f")},
            {3172,  new PantoneColor("617 U", "#bcb174")},
            {3173,  new PantoneColor("618", "#b5aa59")},
            {3174,  new PantoneColor("618 C", "#ad9d3b")},
            {3175,  new PantoneColor("618 U", "#a69c62")},
            {3176,  new PantoneColor("619", "#968c28")},
            {3177,  new PantoneColor("619 C", "#a09028")},
            {3178,  new PantoneColor("619 U", "#968c53")},
            {3179,  new PantoneColor("620", "#847711")},
            {3180,  new PantoneColor("620 C", "#8c7a16")},
            {3181,  new PantoneColor("620 U", "#877e48")},
            {3182,  new PantoneColor("621", "#d8ddce")},
            {3183,  new PantoneColor("621 C", "#d0e0d7")},
            {3184,  new PantoneColor("621 U", "#c7ded3")},
            {3185,  new PantoneColor("622", "#c1d1bf")},
            {3186,  new PantoneColor("622 C", "#b8ccc2")},
            {3187,  new PantoneColor("622 U", "#b0cbc1")},
            {3188,  new PantoneColor("623", "#a5bfaa")},
            {3189,  new PantoneColor("623 C", "#9ab8ac")},
            {3190,  new PantoneColor("623 U", "#95b4aa")},
            {3191,  new PantoneColor("624", "#7fa08c")},
            {3192,  new PantoneColor("624 C", "#789d90")},
            {3193,  new PantoneColor("624 U", "#809f97")},
            {3194,  new PantoneColor("625", "#5b8772")},
            {3195,  new PantoneColor("625 C", "#4f7e70")},
            {3196,  new PantoneColor("625 U", "#698882")},
            {3197,  new PantoneColor("626", "#21543f")},
            {3198,  new PantoneColor("626 C", "#255b4d")},
            {3199,  new PantoneColor("626 U", "#58746e")},
            {3200,  new PantoneColor("627", "#0c3026")},
            {3201,  new PantoneColor("627 C", "#12312a")},
            {3202,  new PantoneColor("627 U", "#425b57")},
            {3203,  new PantoneColor("628", "#cce2dd")},
            {3204,  new PantoneColor("628 C", "#b8dce1")},
            {3205,  new PantoneColor("628 U", "#b3dee6")},
            {3206,  new PantoneColor("629", "#b2d8d8")},
            {3207,  new PantoneColor("629 C", "#99d1dc")},
            {3208,  new PantoneColor("629 U", "#8acedd")},
            {3209,  new PantoneColor("630", "#8cccd3")},
            {3210,  new PantoneColor("630 C", "#76c3d4")},
            {3211,  new PantoneColor("630 U", "#72c2d7")},
            {3212,  new PantoneColor("631", "#54b7c6")},
            {3213,  new PantoneColor("631 C", "#3ab0c8")},
            {3214,  new PantoneColor("631 U", "#4fb0cb")},
            {3215,  new PantoneColor("632", "#00a0ba")},
            {3216,  new PantoneColor("632 C", "#0091b2")},
            {3217,  new PantoneColor("632 U", "#3096b4")},
            {3218,  new PantoneColor("633", "#007f99")},
            {3219,  new PantoneColor("633 C", "#007197")},
            {3220,  new PantoneColor("633 U", "#21809e")},
            {3221,  new PantoneColor("634", "#00667f")},
            {3222,  new PantoneColor("634 C", "#005c82")},
            {3223,  new PantoneColor("634 U", "#1a6c8a")},
            {3224,  new PantoneColor("635", "#bae0e0")},
            {3225,  new PantoneColor("635 C", "#a3d9e7")},
            {3226,  new PantoneColor("635 U", "#a9e1ee")},
            {3227,  new PantoneColor("636", "#99d6dd")},
            {3228,  new PantoneColor("636 C", "#89d2e6")},
            {3229,  new PantoneColor("636 U", "#85d7ee")},
            {3230,  new PantoneColor("637", "#6bc9db")},
            {3231,  new PantoneColor("637 C", "#4dc1df")},
            {3232,  new PantoneColor("637 U", "#58c6e5")},
            {3233,  new PantoneColor("638", "#00b5d6")},
            {3234,  new PantoneColor("638 U", "#28b5de")},
            {3235,  new PantoneColor("639", "#00a0c4")},
            {3236,  new PantoneColor("639 C", "#0093c9")},
            {3237,  new PantoneColor("639 U", "#009bcd")},
            {3238,  new PantoneColor("640", "#008cb2")},
            {3239,  new PantoneColor("640 C", "#0080bb")},
            {3240,  new PantoneColor("640 U", "#0088b9")},
            {3241,  new PantoneColor("641", "#007aa5")},
            {3242,  new PantoneColor("641 C", "#0065a0")},
            {3243,  new PantoneColor("641 U", "#0076a6")},
            {3244,  new PantoneColor("642", "#d1d8d8")},
            {3245,  new PantoneColor("642 C", "#d4dce5")},
            {3246,  new PantoneColor("642 U", "#d1deea")},
            {3247,  new PantoneColor("643", "#c6d1d6")},
            {3248,  new PantoneColor("643 C", "#c7d4e2")},
            {3249,  new PantoneColor("643 U", "#bfd1e4")},
            {3250,  new PantoneColor("644", "#9bafc4")},
            {3251,  new PantoneColor("644 C", "#9cb6d2")},
            {3252,  new PantoneColor("644 U", "#9db7d3")},
            {3253,  new PantoneColor("645", "#7796b2")},
            {3254,  new PantoneColor("645 C", "#7da0c3")},
            {3255,  new PantoneColor("645 U", "#83a1c4")},
            {3256,  new PantoneColor("646", "#5e82a3")},
            {3257,  new PantoneColor("646 C", "#5d89b3")},
            {3258,  new PantoneColor("646 U", "#6c8baf")},
            {3259,  new PantoneColor("647", "#26547c")},
            {3260,  new PantoneColor("647 C", "#265f92")},
            {3261,  new PantoneColor("647 U", "#5c799c")},
            {3262,  new PantoneColor("648", "#00305e")},
            {3263,  new PantoneColor("648 C", "#002c5c")},
            {3264,  new PantoneColor("648 U", "#4e6080")},
            {3265,  new PantoneColor("649", "#d6d6d8")},
            {3266,  new PantoneColor("649 C", "#dce1e9")},
            {3267,  new PantoneColor("649 U", "#dee6ed")},
            {3268,  new PantoneColor("650", "#bfc6d1")},
            {3269,  new PantoneColor("650 C", "#cfd9e5")},
            {3270,  new PantoneColor("650 U", "#d6dfea")},
            {3271,  new PantoneColor("651", "#9baabf")},
            {3272,  new PantoneColor("651 C", "#a8bbd5")},
            {3273,  new PantoneColor("651 U", "#afc2dc")},
            {3274,  new PantoneColor("652", "#6d87a8")},
            {3275,  new PantoneColor("652 C", "#7e9abf")},
            {3276,  new PantoneColor("652 U", "#89a1c3")},
            {3277,  new PantoneColor("653", "#335687")},
            {3278,  new PantoneColor("653 C", "#346094")},
            {3279,  new PantoneColor("653 U", "#687fa4")},
            {3280,  new PantoneColor("654", "#0f2b5b")},
            {3281,  new PantoneColor("654 C", "#00396f")},
            {3282,  new PantoneColor("654 U", "#53688c")},
            {3283,  new PantoneColor("655", "#0c1c47")},
            {3284,  new PantoneColor("655 C", "#002453")},
            {3285,  new PantoneColor("655 U", "#4d5b7e")},
            {3286,  new PantoneColor("656", "#d6dbe0")},
            {3287,  new PantoneColor("656 C", "#dee3eb")},
            {3288,  new PantoneColor("656 U", "#e1e9f2")},
            {3289,  new PantoneColor("657", "#c1c9dd")},
            {3290,  new PantoneColor("657 C", "#cad7eb")},
            {3291,  new PantoneColor("657 U", "#d5e0f1")},
            {3292,  new PantoneColor("658", "#a5afd6")},
            {3293,  new PantoneColor("658 C", "#b2c8e8")},
            {3294,  new PantoneColor("658 U", "#b8ceee")},
            {3295,  new PantoneColor("659", "#7f8cbf")},
            {3296,  new PantoneColor("659 C", "#7ba3dc")},
            {3297,  new PantoneColor("659 U", "#94b4e6")},
            {3298,  new PantoneColor("660", "#5960a8")},
            {3299,  new PantoneColor("660 C", "#407cc9")},
            {3300,  new PantoneColor("660 U", "#6289ca")},
            {3301,  new PantoneColor("661", "#2d338e")},
            {3302,  new PantoneColor("661 C", "#003494")},
            {3303,  new PantoneColor("661 U", "#4666aa")},
            {3304,  new PantoneColor("662", "#0c1975")},
            {3305,  new PantoneColor("662 C", "#001b70")},
            {3306,  new PantoneColor("662 U", "#415290")},
            {3307,  new PantoneColor("663", "#e2d3d6")},
            {3308,  new PantoneColor("663 C", "#e6e1e5")},
            {3309,  new PantoneColor("663 U", "#e1d8e1")},
            {3310,  new PantoneColor("664", "#d8ccd1")},
            {3311,  new PantoneColor("664 C", "#e1dae1")},
            {3312,  new PantoneColor("664 U", "#d9cfdc")},
            {3313,  new PantoneColor("665", "#c6b5c4")},
            {3314,  new PantoneColor("665 C", "#c8bbcf")},
            {3315,  new PantoneColor("665 U", "#c4b8ce")},
            {3316,  new PantoneColor("666", "#a893ad")},
            {3317,  new PantoneColor("666 C", "#a391b1")},
            {3318,  new PantoneColor("666 U", "#aea0bc")},
            {3319,  new PantoneColor("667", "#7f6689")},
            {3320,  new PantoneColor("667 C", "#7d6890")},
            {3321,  new PantoneColor("667 U", "#8f829f")},
            {3322,  new PantoneColor("668", "#664975")},
            {3323,  new PantoneColor("668 C", "#634b77")},
            {3324,  new PantoneColor("668 U", "#82728f")},
            {3325,  new PantoneColor("669", "#472b59")},
            {3326,  new PantoneColor("669 C", "#3f2a55")},
            {3327,  new PantoneColor("669 U", "#71627e")},
            {3328,  new PantoneColor("670", "#f2d6d8")},
            {3329,  new PantoneColor("670 C", "#edd2e1")},
            {3330,  new PantoneColor("670 U", "#f4d4e4")},
            {3331,  new PantoneColor("671", "#efc6d3")},
            {3332,  new PantoneColor("671 C", "#e9bbd7")},
            {3333,  new PantoneColor("671 U", "#f2c2dd")},
            {3334,  new PantoneColor("672", "#eaaac4")},
            {3335,  new PantoneColor("672 C", "#e39fc8")},
            {3336,  new PantoneColor("672 U", "#eca6cc")},
            {3337,  new PantoneColor("673", "#e08cb2")},
            {3338,  new PantoneColor("673 C", "#df84ba")},
            {3339,  new PantoneColor("673 U", "#e38bba")},
            {3340,  new PantoneColor("674", "#d36b9e")},
            {3341,  new PantoneColor("674 C", "#cd5599")},
            {3342,  new PantoneColor("674 U", "#d1709f")},
            {3343,  new PantoneColor("675", "#bc3877")},
            {3344,  new PantoneColor("675 C", "#b42371")},
            {3345,  new PantoneColor("675 U", "#c05f8d")},
            {3346,  new PantoneColor("676", "#a00054")},
            {3347,  new PantoneColor("676 C", "#9b004e")},
            {3348,  new PantoneColor("676 U", "#ac4f77")},
            {3349,  new PantoneColor("677", "#edd6d6")},
            {3350,  new PantoneColor("677 C", "#e8cddb")},
            {3351,  new PantoneColor("677 U", "#eed0e0")},
            {3352,  new PantoneColor("678", "#eaccce")},
            {3353,  new PantoneColor("678 C", "#e7c7d7")},
            {3354,  new PantoneColor("678 U", "#e8bfd3")},
            {3355,  new PantoneColor("679", "#e5bfc6")},
            {3356,  new PantoneColor("679 C", "#e0bdd2")},
            {3357,  new PantoneColor("679 U", "#dcabc6")},
            {3358,  new PantoneColor("680", "#d39eaf")},
            {3359,  new PantoneColor("680 C", "#cd94b3")},
            {3360,  new PantoneColor("680 U", "#c28aa7")},
            {3361,  new PantoneColor("681", "#b7728e")},
            {3362,  new PantoneColor("681 C", "#b46a94")},
            {3363,  new PantoneColor("681 U", "#a86e8c")},
            {3364,  new PantoneColor("682", "#a05175")},
            {3365,  new PantoneColor("682 C", "#9d4777")},
            {3366,  new PantoneColor("682 U", "#915c76")},
            {3367,  new PantoneColor("683", "#7f284f")},
            {3368,  new PantoneColor("683 C", "#7f2754")},
            {3369,  new PantoneColor("683 U", "#825166")},
            {3370,  new PantoneColor("684", "#efccce")},
            {3371,  new PantoneColor("684 C", "#e5c5d3")},
            {3372,  new PantoneColor("684 U", "#eccbd9")},
            {3373,  new PantoneColor("685", "#eabfc4")},
            {3374,  new PantoneColor("685 C", "#deb5c8")},
            {3375,  new PantoneColor("685 U", "#e4bdcf")},
            {3376,  new PantoneColor("686", "#e0aaba")},
            {3377,  new PantoneColor("686 C", "#d39fb7")},
            {3378,  new PantoneColor("686 U", "#d6a6bd")},
            {3379,  new PantoneColor("687", "#c9899e")},
            {3380,  new PantoneColor("687 C", "#c184a3")},
            {3381,  new PantoneColor("687 U", "#be8ca5")},
            {3382,  new PantoneColor("688", "#b26684")},
            {3383,  new PantoneColor("688 C", "#ab6388")},
            {3384,  new PantoneColor("688 U", "#a3728b")},
            {3385,  new PantoneColor("689", "#934266")},
            {3386,  new PantoneColor("689 C", "#8c3b66")},
            {3387,  new PantoneColor("689 U", "#8e6176")},
            {3388,  new PantoneColor("690", "#702342")},
            {3389,  new PantoneColor("690 C", "#64223f")},
            {3390,  new PantoneColor("690 U", "#7d4f5f")},
            {3391,  new PantoneColor("691", "#efd1c9")},
            {3392,  new PantoneColor("691 C", "#ecccce")},
            {3393,  new PantoneColor("691 U", "#f1d2d3")},
            {3394,  new PantoneColor("692", "#e8bfba")},
            {3395,  new PantoneColor("692 C", "#e6bec2")},
            {3396,  new PantoneColor("693", "#dba8a5")},
            {3397,  new PantoneColor("693 C", "#dba2aa")},
            {3398,  new PantoneColor("693 U", "#dba4ab")},
            {3399,  new PantoneColor("694", "#c98c8c")},
            {3400,  new PantoneColor("694 C", "#c7848f")},
            {3401,  new PantoneColor("694 U", "#c48c94")},
            {3402,  new PantoneColor("695", "#b26b70")},
            {3403,  new PantoneColor("695 C", "#b86b78")},
            {3404,  new PantoneColor("695 U", "#ad757e")},
            {3405,  new PantoneColor("696", "#8e4749")},
            {3406,  new PantoneColor("696 C", "#9b4755")},
            {3407,  new PantoneColor("696 U", "#99646b")},
            {3408,  new PantoneColor("697", "#7f383a")},
            {3409,  new PantoneColor("697 C", "#8c3b44")},
            {3410,  new PantoneColor("697 U", "#87555a")},
            {3411,  new PantoneColor("698", "#f7d1cc")},
            {3412,  new PantoneColor("698 C", "#f5d3d6")},
            {3413,  new PantoneColor("698 U", "#fbd6d9")},
            {3414,  new PantoneColor("699", "#f7bfbf")},
            {3415,  new PantoneColor("699 U", "#fec0c9")},
            {3416,  new PantoneColor("700", "#f2a5aa")},
            {3417,  new PantoneColor("700 C", "#f7acb8")},
            {3418,  new PantoneColor("700 U", "#f9a9b5")},
            {3419,  new PantoneColor("701", "#e8878e")},
            {3420,  new PantoneColor("701 C", "#ea8597")},
            {3421,  new PantoneColor("701 U", "#ec8e9d")},
            {3422,  new PantoneColor("702", "#d6606d")},
            {3423,  new PantoneColor("702 C", "#d75c71")},
            {3424,  new PantoneColor("702 U", "#db7886")},
            {3425,  new PantoneColor("703", "#b73844")},
            {3426,  new PantoneColor("703 C", "#bd3a49")},
            {3427,  new PantoneColor("703 U", "#b65a64")},
            {3428,  new PantoneColor("704", "#9e2828")},
            {3429,  new PantoneColor("704 C", "#a2292e")},
            {3430,  new PantoneColor("704 U", "#a54f56")},
            {3431,  new PantoneColor("705", "#f9ddd6")},
            {3432,  new PantoneColor("705 C", "#f8dadf")},
            {3433,  new PantoneColor("705 U", "#ffdce0")},
            {3434,  new PantoneColor("706", "#fcc9c6")},
            {3435,  new PantoneColor("706 C", "#f8cdd6")},
            {3436,  new PantoneColor("706 U", "#ffc9d2")},
            {3437,  new PantoneColor("707", "#fcadaf")},
            {3438,  new PantoneColor("707 C", "#fbb5c3")},
            {3439,  new PantoneColor("707 U", "#ffb0be")},
            {3440,  new PantoneColor("708", "#f98e99")},
            {3441,  new PantoneColor("708 C", "#fc91a2")},
            {3442,  new PantoneColor("708 U", "#ff97a6")},
            {3443,  new PantoneColor("709", "#f26877")},
            {3444,  new PantoneColor("709 C", "#f46177")},
            {3445,  new PantoneColor("709 U", "#f87b88")},
            {3446,  new PantoneColor("710", "#e04251")},
            {3447,  new PantoneColor("710 C", "#e73d50")},
            {3448,  new PantoneColor("710 U", "#e9636e")},
            {3449,  new PantoneColor("711", "#d12d33")},
            {3450,  new PantoneColor("711 C", "#d12a2e")},
            {3451,  new PantoneColor("711 U", "#d24f53")},
            {3452,  new PantoneColor("712", "#ffd3aa")},
            {3453,  new PantoneColor("712 C", "#ffc999")},
            {3454,  new PantoneColor("712 U", "#ffca9c")},
            {3455,  new PantoneColor("713", "#f9c9a3")},
            {3456,  new PantoneColor("713 C", "#ffbe84")},
            {3457,  new PantoneColor("713 U", "#ffc18f")},
            {3458,  new PantoneColor("714", "#f9ba82")},
            {3459,  new PantoneColor("714 C", "#ffa960")},
            {3460,  new PantoneColor("714 U", "#ffb078")},
            {3461,  new PantoneColor("715", "#fc9e49")},
            {3462,  new PantoneColor("715 C", "#f98d29")},
            {3463,  new PantoneColor("715 U", "#fb9a61")},
            {3464,  new PantoneColor("716", "#f28411")},
            {3465,  new PantoneColor("716 C", "#ed7700")},
            {3466,  new PantoneColor("716 U", "#eb854f")},
            {3467,  new PantoneColor("717", "#d36d00")},
            {3468,  new PantoneColor("717 C", "#d75e00")},
            {3469,  new PantoneColor("717 U", "#da763e")},
            {3470,  new PantoneColor("718", "#bf5b00")},
            {3471,  new PantoneColor("718 C", "#c14d00")},
            {3472,  new PantoneColor("718 U", "#c96d3c")},
            {3473,  new PantoneColor("719", "#f4d1af")},
            {3474,  new PantoneColor("719 C", "#eec7a1")},
            {3475,  new PantoneColor("719 U", "#f2c5a1")},
            {3476,  new PantoneColor("720", "#efc49e")},
            {3477,  new PantoneColor("720 C", "#e9b789")},
            {3478,  new PantoneColor("720 U", "#edba92")},
            {3479,  new PantoneColor("721", "#e8b282")},
            {3480,  new PantoneColor("721 C", "#dfa36c")},
            {3481,  new PantoneColor("721 U", "#dfa77e")},
            {3482,  new PantoneColor("722", "#d18e54")},
            {3483,  new PantoneColor("722 C", "#cb8241")},
            {3484,  new PantoneColor("722 U", "#cb916a")},
            {3485,  new PantoneColor("723", "#ba7530")},
            {3486,  new PantoneColor("723 C", "#b46a1f")},
            {3487,  new PantoneColor("723 U", "#b9825e")},
            {3488,  new PantoneColor("724", "#8e4905")},
            {3489,  new PantoneColor("724 C", "#954e0e")},
            {3490,  new PantoneColor("724 U", "#a6734e")},
            {3491,  new PantoneColor("725", "#753802")},
            {3492,  new PantoneColor("725 C", "#7f4014")},
            {3493,  new PantoneColor("725 U", "#966746")},
            {3494,  new PantoneColor("726", "#edd3b5")},
            {3495,  new PantoneColor("726 C", "#e2c19d")},
            {3496,  new PantoneColor("726 U", "#e8c5a8")},
            {3497,  new PantoneColor("727", "#e2bf9b")},
            {3498,  new PantoneColor("727 C", "#dcb38c")},
            {3499,  new PantoneColor("727 U", "#dcb495")},
            {3500,  new PantoneColor("728", "#d3a87c")},
            {3501,  new PantoneColor("728 C", "#cfa075")},
            {3502,  new PantoneColor("728 U", "#c9a081")},
            {3503,  new PantoneColor("729", "#c18e60")},
            {3504,  new PantoneColor("729 C", "#b7814f")},
            {3505,  new PantoneColor("729 U", "#bd9274")},
            {3506,  new PantoneColor("730", "#aa753f")},
            {3507,  new PantoneColor("730 C", "#a0662c")},
            {3508,  new PantoneColor("730 U", "#a47d61")},
            {3509,  new PantoneColor("731", "#723f0a")},
            {3510,  new PantoneColor("731 C", "#79420f")},
            {3511,  new PantoneColor("731 U", "#967155")},
            {3512,  new PantoneColor("732", "#60330a")},
            {3513,  new PantoneColor("732 C", "#64340f")},
            {3514,  new PantoneColor("732 U", "#89674c")},
            {3515,  new PantoneColor("7401 C", "#f8e0a4")},
            {3516,  new PantoneColor("7401 U", "#ffe3a4")},
            {3517,  new PantoneColor("7402 C", "#eed797")},
            {3518,  new PantoneColor("7402 U", "#f5d999")},
            {3519,  new PantoneColor("7403 C", "#f1d282")},
            {3520,  new PantoneColor("7403 U", "#f6ce81")},
            {3521,  new PantoneColor("7404 C", "#f7d93d")},
            {3522,  new PantoneColor("7404 U", "#ffcd3f")},
            {3523,  new PantoneColor("7405 C", "#f3cd00")},
            {3524,  new PantoneColor("7405 U", "#e7b107")},
            {3525,  new PantoneColor("7406 C", "#f4c300")},
            {3526,  new PantoneColor("7406 U", "#f2b726")},
            {3527,  new PantoneColor("7407 C", "#ce9f51")},
            {3528,  new PantoneColor("7407 U", "#cea36e")},
            {3529,  new PantoneColor("7408 C", "#f9be00")},
            {3530,  new PantoneColor("7408 U", "#f09d23")},
            {3531,  new PantoneColor("7409 C", "#f6b221")},
            {3532,  new PantoneColor("7409 U", "#fbac4e")},
            {3533,  new PantoneColor("7410 C", "#ffae75")},
            {3534,  new PantoneColor("7410 U", "#ffa06d")},
            {3535,  new PantoneColor("7411 C", "#eba55d")},
            {3536,  new PantoneColor("7411 U", "#eca06f")},
            {3537,  new PantoneColor("7412 C", "#d68230")},
            {3538,  new PantoneColor("7412 U", "#d18b5e")},
            {3539,  new PantoneColor("7413 C", "#e18431")},
            {3540,  new PantoneColor("7413 U", "#e28758")},
            {3541,  new PantoneColor("7414 C", "#c46c13")},
            {3542,  new PantoneColor("7414 U", "#c27e51")},
            {3543,  new PantoneColor("7415 C", "#eab8a6")},
            {3544,  new PantoneColor("7415 U", "#eeb3a4")},
            {3545,  new PantoneColor("7416 C", "#eb6851")},
            {3546,  new PantoneColor("7416 U", "#f0716a")},
            {3547,  new PantoneColor("7417 C", "#e84a37")},
            {3548,  new PantoneColor("7417 U", "#ed6960")},
            {3549,  new PantoneColor("7418 C", "#d15458")},
            {3550,  new PantoneColor("7418 U", "#c16364")},
            {3551,  new PantoneColor("7419 C", "#b24b58")},
            {3552,  new PantoneColor("7419 U", "#a66269")},
            {3553,  new PantoneColor("7420 C", "#a02040")},
            {3554,  new PantoneColor("7420 U", "#a75767")},
            {3555,  new PantoneColor("7421 C", "#6a1a31")},
            {3556,  new PantoneColor("7421 U", "#7e4d5a")},
            {3557,  new PantoneColor("7422 C", "#f6cdd3")},
            {3558,  new PantoneColor("7422 U", "#fdd4d8")},
            {3559,  new PantoneColor("7423 C", "#e46285")},
            {3560,  new PantoneColor("7423 U", "#e7758d")},
            {3561,  new PantoneColor("7424 C", "#e74582")},
            {3562,  new PantoneColor("7424 U", "#dc567a")},
            {3563,  new PantoneColor("7425 C", "#ba2253")},
            {3564,  new PantoneColor("7425 U", "#be5a72")},
            {3565,  new PantoneColor("7426 C", "#a80f3d")},
            {3566,  new PantoneColor("7426 U", "#b55469")},
            {3567,  new PantoneColor("7427 C", "#9d162e")},
            {3568,  new PantoneColor("7427 U", "#a9515c")},
            {3569,  new PantoneColor("7428 C", "#6d2a3c")},
            {3570,  new PantoneColor("7428 U", "#815b65")},
            {3571,  new PantoneColor("7429 C", "#e5bac9")},
            {3572,  new PantoneColor("7429 U", "#eecbd8")},
            {3573,  new PantoneColor("7430 C", "#e0a8be")},
            {3574,  new PantoneColor("7430 U", "#e8b4c8")},
            {3575,  new PantoneColor("7431 C", "#ce7e9c")},
            {3576,  new PantoneColor("7431 U", "#dfa1b8")},
            {3577,  new PantoneColor("7432 C", "#bb5a7f")},
            {3578,  new PantoneColor("7432 U", "#c78099")},
            {3579,  new PantoneColor("7433 C", "#ad3863")},
            {3580,  new PantoneColor("7433 U", "#bb6e87")},
            {3581,  new PantoneColor("7434 C", "#9f3058")},
            {3582,  new PantoneColor("7434 U", "#ab667b")},
            {3583,  new PantoneColor("7435 C", "#8a244e")},
            {3584,  new PantoneColor("7435 U", "#8e556a")},
            {3585,  new PantoneColor("7436 C", "#f2dae9")},
            {3586,  new PantoneColor("7436 U", "#f4d4ec")},
            {3587,  new PantoneColor("7437 C", "#cfacce")},
            {3588,  new PantoneColor("7437 U", "#d6b4d4")},
            {3589,  new PantoneColor("7438 C", "#d89dd7")},
            {3590,  new PantoneColor("7438 U", "#da9ad6")},
            {3591,  new PantoneColor("7439 C", "#b687b8")},
            {3592,  new PantoneColor("7439 U", "#c19cc5")},
            {3593,  new PantoneColor("7440 C", "#a776a5")},
            {3594,  new PantoneColor("7440 U", "#b894b8")},
            {3595,  new PantoneColor("7441 C", "#a25cbf")},
            {3596,  new PantoneColor("7441 U", "#b07dc9")},
            {3597,  new PantoneColor("7442 C", "#9a3cbb")},
            {3598,  new PantoneColor("7442 U", "#9e62bb")},
            {3599,  new PantoneColor("7443 C", "#dedae8")},
            {3600,  new PantoneColor("7443 U", "#ddd7ea")},
            {3601,  new PantoneColor("7444 C", "#b7b8dc")},
            {3602,  new PantoneColor("7444 U", "#bcbce1")},
            {3603,  new PantoneColor("7445 C", "#a8a1c1")},
            {3604,  new PantoneColor("7445 U", "#aca7c6")},
            {3605,  new PantoneColor("7446 C", "#8c85c9")},
            {3606,  new PantoneColor("7446 U", "#9491cf")},
            {3607,  new PantoneColor("7447 C", "#604775")},
            {3608,  new PantoneColor("7447 U", "#7e7292")},
            {3609,  new PantoneColor("7448 C", "#4c374b")},
            {3610,  new PantoneColor("7448 U", "#726774")},
            {3611,  new PantoneColor("7449 C", "#43263a")},
            {3612,  new PantoneColor("7449 U", "#63505b")},
            {3613,  new PantoneColor("7450 C", "#bec3d9")},
            {3614,  new PantoneColor("7450 U", "#c2c9df")},
            {3615,  new PantoneColor("7451 C", "#89a9e2")},
            {3616,  new PantoneColor("7451 U", "#93b1e9")},
            {3617,  new PantoneColor("7452 C", "#8193dc")},
            {3618,  new PantoneColor("7452 U", "#8fa0e4")},
            {3619,  new PantoneColor("7453 C", "#7ca4dd")},
            {3620,  new PantoneColor("7453 U", "#85abe3")},
            {3621,  new PantoneColor("7454 C", "#618db4")},
            {3622,  new PantoneColor("7454 U", "#7597bb")},
            {3623,  new PantoneColor("7455 C", "#3a5cac")},
            {3624,  new PantoneColor("7455 U", "#677cb8")},
            {3625,  new PantoneColor("7456 C", "#606db2")},
            {3626,  new PantoneColor("7456 U", "#7f88be")},
            {3627,  new PantoneColor("7457 C", "#bbdbe5")},
            {3628,  new PantoneColor("7457 U", "#bde1ec")},
            {3629,  new PantoneColor("7458 C", "#71b1c8")},
            {3630,  new PantoneColor("7458 U", "#65a4be")},
            {3631,  new PantoneColor("7459 C", "#4196b4")},
            {3632,  new PantoneColor("7459 U", "#4f8ca9")},
            {3633,  new PantoneColor("7460 C", "#0083c1")},
            {3634,  new PantoneColor("7460 U", "#008bc1")},
            {3635,  new PantoneColor("7461 C", "#007cba")},
            {3636,  new PantoneColor("7461 U", "#3e90c6")},
            {3637,  new PantoneColor("7462 C", "#00538a")},
            {3638,  new PantoneColor("7462 U", "#5479a2")},
            {3639,  new PantoneColor("7463 C", "#002a48")},
            {3640,  new PantoneColor("7463 U", "#50647d")},
            {3641,  new PantoneColor("7464 C", "#a1cfca")},
            {3642,  new PantoneColor("7464 U", "#a9d9d7")},
            {3643,  new PantoneColor("7465 C", "#3ebfac")},
            {3644,  new PantoneColor("7465 U", "#4dc4b5")},
            {3645,  new PantoneColor("7466 C", "#00adbb")},
            {3646,  new PantoneColor("7466 U", "#00b1bd")},
            {3647,  new PantoneColor("7467 C", "#00a0ae")},
            {3648,  new PantoneColor("7467 U", "#00a5b3")},
            {3649,  new PantoneColor("7468 C", "#007298")},
            {3650,  new PantoneColor("7468 U", "#3c7594")},
            {3651,  new PantoneColor("7469 C", "#005d85")},
            {3652,  new PantoneColor("7469 U", "#376c89")},
            {3653,  new PantoneColor("7470 C", "#00576f")},
            {3654,  new PantoneColor("7470 U", "#426f83")},
            {3655,  new PantoneColor("7471 C", "#7ddbd3")},
            {3656,  new PantoneColor("7471 U", "#79e0da")},
            {3657,  new PantoneColor("7472 C", "#5ab6b2")},
            {3658,  new PantoneColor("7472 U", "#67bcb8")},
            {3659,  new PantoneColor("7473 C", "#1e988a")},
            {3660,  new PantoneColor("7473 U", "#5ba39a")},
            {3661,  new PantoneColor("7474 C", "#007480")},
            {3662,  new PantoneColor("7474 U", "#3e8994")},
            {3663,  new PantoneColor("7475 C", "#46797a")},
            {3664,  new PantoneColor("7475 U", "#68898c")},
            {3665,  new PantoneColor("7476 C", "#075056")},
            {3666,  new PantoneColor("7476 U", "#57767b")},
            {3667,  new PantoneColor("7477 C", "#264b59")},
            {3668,  new PantoneColor("7477 U", "#5d6f78")},
            {3669,  new PantoneColor("7478 C", "#97e2be")},
            {3670,  new PantoneColor("7478 U", "#9be9c5")},
            {3671,  new PantoneColor("7479 C", "#05ce7b")},
            {3672,  new PantoneColor("7479 U", "#01c97f")},
            {3673,  new PantoneColor("7480 C", "#00bc6f")},
            {3674,  new PantoneColor("7480 U", "#00bf81")},
            {3675,  new PantoneColor("7481 C", "#00b44f")},
            {3676,  new PantoneColor("7481 U", "#00b76d")},
            {3677,  new PantoneColor("7482 C", "#009d4e")},
            {3678,  new PantoneColor("7482 U", "#1da46f")},
            {3679,  new PantoneColor("7483 C", "#235c37")},
            {3680,  new PantoneColor("7483 U", "#567662")},
            {3681,  new PantoneColor("7484 U", "#436d60")},
            {3682,  new PantoneColor("7485 C", "#d1ddba")},
            {3683,  new PantoneColor("7485 U", "#d5e3c0")},
            {3684,  new PantoneColor("7486 C", "#bcdf92")},
            {3685,  new PantoneColor("7486 U", "#b4e192")},
            {3686,  new PantoneColor("7487 C", "#8bdc64")},
            {3687,  new PantoneColor("7487 U", "#84df75")},
            {3688,  new PantoneColor("7488 C", "#72d54a")},
            {3689,  new PantoneColor("7488 U", "#5ace5a")},
            {3690,  new PantoneColor("7489 C", "#72a84f")},
            {3691,  new PantoneColor("7489 U", "#79a96b")},
            {3692,  new PantoneColor("7490 C", "#739849")},
            {3693,  new PantoneColor("7490 U", "#7a9d6c")},
            {3694,  new PantoneColor("7491 C", "#79843b")},
            {3695,  new PantoneColor("7491 U", "#808a60")},
            {3696,  new PantoneColor("7492 C", "#c2ca7f")},
            {3697,  new PantoneColor("7492 U", "#bcc986")},
            {3698,  new PantoneColor("7493 C", "#bdc391")},
            {3699,  new PantoneColor("7493 U", "#b5c093")},
            {3700,  new PantoneColor("7494 C", "#9cae87")},
            {3701,  new PantoneColor("7494 U", "#9dae90")},
            {3702,  new PantoneColor("7495 C", "#90993d")},
            {3703,  new PantoneColor("7495 U", "#828d58")},
            {3704,  new PantoneColor("7496 C", "#77871c")},
            {3705,  new PantoneColor("7496 U", "#738348")},
            {3706,  new PantoneColor("7497 C", "#7b7156")},
            {3707,  new PantoneColor("7497 U", "#8b8776")},
            {3708,  new PantoneColor("7498 C", "#5c6134")},
            {3709,  new PantoneColor("7498 U", "#767b63")},
            {3710,  new PantoneColor("7499 C", "#f2e4b1")},
            {3711,  new PantoneColor("7499 U", "#faecbb")},
            {3712,  new PantoneColor("7500 C", "#e1d0a5")},
            {3713,  new PantoneColor("7500 U", "#e6d4ab")},
            {3714,  new PantoneColor("7501 C", "#dac79d")},
            {3715,  new PantoneColor("7501 U", "#dfc9a4")},
            {3716,  new PantoneColor("7502 C", "#d1b786")},
            {3717,  new PantoneColor("7502 U", "#c9ae86")},
            {3718,  new PantoneColor("7503 C", "#ab9766")},
            {3719,  new PantoneColor("7503 U", "#9e9171")},
            {3720,  new PantoneColor("7504 C", "#96785d")},
            {3721,  new PantoneColor("7504 U", "#968171")},
            {3722,  new PantoneColor("7505 C", "#83603f")},
            {3723,  new PantoneColor("7505 U", "#887465")},
            {3724,  new PantoneColor("7506 C", "#f3dab1")},
            {3725,  new PantoneColor("7506 U", "#fbdfb7")},
            {3726,  new PantoneColor("7507 C", "#fed198")},
            {3727,  new PantoneColor("7507 U", "#ffdca9")},
            {3728,  new PantoneColor("7508 C", "#e2b77d")},
            {3729,  new PantoneColor("7508 U", "#e0b384")},
            {3730,  new PantoneColor("7509 C", "#d8a460")},
            {3731,  new PantoneColor("7509 U", "#d2a172")},
            {3732,  new PantoneColor("7510 C", "#c8893c")},
            {3733,  new PantoneColor("7510 U", "#be8b5f")},
            {3734,  new PantoneColor("7511 C", "#ba7726")},
            {3735,  new PantoneColor("7511 U", "#a8774f")},
            {3736,  new PantoneColor("7512 C", "#a86318")},
            {3737,  new PantoneColor("7512 U", "#986a47")},
            {3738,  new PantoneColor("7513 C", "#e3b6a4")},
            {3739,  new PantoneColor("7513 U", "#e7bab2")},
            {3740,  new PantoneColor("7514 C", "#d7a284")},
            {3741,  new PantoneColor("7514 U", "#dbaa9a")},
            {3742,  new PantoneColor("7515 C", "#c78b66")},
            {3743,  new PantoneColor("7515 U", "#c4907e")},
            {3744,  new PantoneColor("7516 C", "#9c542a")},
            {3745,  new PantoneColor("7516 U", "#a17462")},
            {3746,  new PantoneColor("7517 C", "#89421c")},
            {3747,  new PantoneColor("7517 U", "#946856")},
            {3748,  new PantoneColor("7518 C", "#6f4e46")},
            {3749,  new PantoneColor("7518 U", "#807070")},
            {3750,  new PantoneColor("7519 C", "#5f4a3b")},
            {3751,  new PantoneColor("7519 U", "#746a65")},
            {3752,  new PantoneColor("7520 C", "#edbeaf")},
            {3753,  new PantoneColor("7520 U", "#f3c4bf")},
            {3754,  new PantoneColor("7521 C", "#c49a81")},
            {3755,  new PantoneColor("7521 U", "#c7a095")},
            {3756,  new PantoneColor("7522 C", "#ba6954")},
            {3757,  new PantoneColor("7522 U", "#b27670")},
            {3758,  new PantoneColor("7523 C", "#af5c56")},
            {3759,  new PantoneColor("7523 U", "#ab7475")},
            {3760,  new PantoneColor("7524 C", "#a85147")},
            {3761,  new PantoneColor("7524 U", "#a56d69")},
            {3762,  new PantoneColor("7525 C", "#9f684f")},
            {3763,  new PantoneColor("7525 U", "#9b776e")},
            {3764,  new PantoneColor("7526 C", "#8d3a18")},
            {3765,  new PantoneColor("7526 U", "#935e50")},
            {3766,  new PantoneColor("7527 C", "#d7d1c4")},
            {3767,  new PantoneColor("7527 U", "#dcd6d1")},
            {3768,  new PantoneColor("7528 C", "#c7b9ab")},
            {3769,  new PantoneColor("7528 U", "#d2c7c3")},
            {3770,  new PantoneColor("7529 C", "#b7a998")},
            {3771,  new PantoneColor("7529 U", "#baaea8")},
            {3772,  new PantoneColor("7530 C", "#a49382")},
            {3773,  new PantoneColor("7530 U", "#a79b94")},
            {3774,  new PantoneColor("7531 C", "#7c6755")},
            {3775,  new PantoneColor("7531 U", "#8a7f78")},
            {3776,  new PantoneColor("7532 C", "#65503c")},
            {3777,  new PantoneColor("7532 U", "#786d64")},
            {3778,  new PantoneColor("7533 C", "#483627")},
            {3779,  new PantoneColor("7533 U", "#6d645b")},
            {3780,  new PantoneColor("7534 C", "#d3ccbc")},
            {3781,  new PantoneColor("7534 U", "#d0c9c2")},
            {3782,  new PantoneColor("7535 C", "#b8b09b")},
            {3783,  new PantoneColor("7535 U", "#c0b9b0")},
            {3784,  new PantoneColor("7536 C", "#a89f87")},
            {3785,  new PantoneColor("7536 U", "#afa79c")},
            {3786,  new PantoneColor("7537 C", "#a9aba0")},
            {3787,  new PantoneColor("7537 U", "#b3b7b5")},
            {3788,  new PantoneColor("7538 C", "#93998f")},
            {3789,  new PantoneColor("7538 U", "#a3a9a7")},
            {3790,  new PantoneColor("7539 C", "#8f8e88")},
            {3791,  new PantoneColor("7539 U", "#9b9d9f")},
            {3792,  new PantoneColor("7540 C", "#4b4e53")},
            {3793,  new PantoneColor("7540 U", "#6f737b")},
            {3794,  new PantoneColor("7541 C", "#dadfe1")},
            {3795,  new PantoneColor("7541 U", "#dae3e6")},
            {3796,  new PantoneColor("7542 C", "#a5bbc2")},
            {3797,  new PantoneColor("7542 U", "#b0c3cb")},
            {3798,  new PantoneColor("7543 C", "#98a3ad")},
            {3799,  new PantoneColor("7543 U", "#adb7c0")},
            {3800,  new PantoneColor("7544 C", "#768591")},
            {3801,  new PantoneColor("7545 C", "#425363")},
            {3802,  new PantoneColor("7545 U", "#77838e")},
            {3803,  new PantoneColor("7546 C", "#263645")},
            {3804,  new PantoneColor("7546 U", "#676f79")},
            {3805,  new PantoneColor("7547 C", "#141d28")},
            {3806,  new PantoneColor("7547 U", "#50525b")},
            {3807,  new PantoneColor("7548 C", "#ffc600")},
            {3808,  new PantoneColor("7548 U", "#ffc908")},
            {3809,  new PantoneColor("7549 C", "#ffb600")},
            {3810,  new PantoneColor("7549 U", "#ffb835")},
            {3811,  new PantoneColor("7550 C", "#d49000")},
            {3812,  new PantoneColor("7550 U", "#ce963b")},
            {3813,  new PantoneColor("7551 C", "#b57f00")},
            {3814,  new PantoneColor("7551 U", "#ae8542")},
            {3815,  new PantoneColor("7552 C", "#75531c")},
            {3816,  new PantoneColor("7552 U", "#816e49")},
            {3817,  new PantoneColor("7553 C", "#5c4520")},
            {3818,  new PantoneColor("7553 U", "#6f644a")},
            {3819,  new PantoneColor("7554 C", "#4c3d29")},
            {3820,  new PantoneColor("7554 U", "#6c6457")},
            {3821,  new PantoneColor("7555 C", "#d39e0a")},
            {3822,  new PantoneColor("7555 U", "#d8a958")},
            {3823,  new PantoneColor("7556 C", "#b88b1c")},
            {3824,  new PantoneColor("7556 U", "#bc985c")},
            {3825,  new PantoneColor("7557 C", "#a27c21")},
            {3826,  new PantoneColor("7557 U", "#a58c5d")},
            {3827,  new PantoneColor("7558 C", "#987023")},
            {3828,  new PantoneColor("7558 U", "#9a825d")},
            {3829,  new PantoneColor("7559 C", "#916928")},
            {3830,  new PantoneColor("7559 U", "#987e5e")},
            {3831,  new PantoneColor("7560 C", "#7f622c")},
            {3832,  new PantoneColor("7560 U", "#8e7d62")},
            {3833,  new PantoneColor("7561 C", "#6d5d34")},
            {3834,  new PantoneColor("7561 U", "#807863")},
            {3835,  new PantoneColor("7562 C", "#bf9a5e")},
            {3836,  new PantoneColor("7562 U", "#be9f77")},
            {3837,  new PantoneColor("7563 C", "#d99a29")},
            {3838,  new PantoneColor("7563 U", "#dba461")},
            {3839,  new PantoneColor("7564 C", "#de8a00")},
            {3840,  new PantoneColor("7564 U", "#df9856")},
            {3841,  new PantoneColor("7565 C", "#cf7a21")},
            {3842,  new PantoneColor("7565 U", "#ca8558")},
            {3843,  new PantoneColor("7566 C", "#b16432")},
            {3844,  new PantoneColor("7566 U", "#b0795d")},
            {3845,  new PantoneColor("7567 C", "#8b532e")},
            {3846,  new PantoneColor("7567 U", "#916f5b")},
            {3847,  new PantoneColor("7568 C", "#795034")},
            {3848,  new PantoneColor("7568 U", "#826b5d")},
            {3849,  new PantoneColor("7569 C", "#db8823")},
            {3850,  new PantoneColor("7569 U", "#d68d56")},
            {3851,  new PantoneColor("7570 C", "#d7832a")},
            {3852,  new PantoneColor("7570 U", "#d48c59")},
            {3853,  new PantoneColor("7571 C", "#ca7c30")},
            {3854,  new PantoneColor("7571 U", "#c5885b")},
            {3855,  new PantoneColor("7572 C", "#ba7131")},
            {3856,  new PantoneColor("7572 U", "#b37f5b")},
            {3857,  new PantoneColor("7573 C", "#aa6529")},
            {3858,  new PantoneColor("7573 U", "#aa7a57")},
            {3859,  new PantoneColor("7574 C", "#a26936")},
            {3860,  new PantoneColor("7574 U", "#9a7659")},
            {3861,  new PantoneColor("7575 C", "#855c31")},
            {3862,  new PantoneColor("7575 U", "#867058")},
            {3863,  new PantoneColor("7576 C", "#e1854e")},
            {3864,  new PantoneColor("7576 U", "#dd8d6a")},
            {3865,  new PantoneColor("7577 C", "#e57d3c")},
            {3866,  new PantoneColor("7577 U", "#e48961")},
            {3867,  new PantoneColor("7578 C", "#e06a2d")},
            {3868,  new PantoneColor("7578 U", "#df7c59")},
            {3869,  new PantoneColor("7579 C", "#e15829")},
            {3870,  new PantoneColor("7579 U", "#e27356")},
            {3871,  new PantoneColor("7580 C", "#c3502f")},
            {3872,  new PantoneColor("7580 U", "#c36c57")},
            {3873,  new PantoneColor("7581 C", "#894833")},
            {3874,  new PantoneColor("7581 U", "#916a5b")},
            {3875,  new PantoneColor("7582 C", "#694634")},
            {3876,  new PantoneColor("7582 U", "#7a675d")},
            {3877,  new PantoneColor("7583 C", "#c9602c")},
            {3878,  new PantoneColor("7583 U", "#cd7b5f")},
            {3879,  new PantoneColor("7584 C", "#c05626")},
            {3880,  new PantoneColor("7584 U", "#c37558")},
            {3881,  new PantoneColor("7585 C", "#b55a37")},
            {3882,  new PantoneColor("7585 U", "#b97865")},
            {3883,  new PantoneColor("7586 C", "#a3512f")},
            {3884,  new PantoneColor("7586 U", "#a56f5c")},
            {3885,  new PantoneColor("7587 C", "#964a2c")},
            {3886,  new PantoneColor("7587 U", "#9b6c5b")},
            {3887,  new PantoneColor("7588 C", "#7f4b35")},
            {3888,  new PantoneColor("7588 U", "#896c60")},
            {3889,  new PantoneColor("7589 C", "#5f4536")},
            {3890,  new PantoneColor("7589 U", "#746962")},
            {3891,  new PantoneColor("7590 C", "#d7b49d")},
            {3892,  new PantoneColor("7590 U", "#debba8")},
            {3893,  new PantoneColor("7591 C", "#c57c59")},
            {3894,  new PantoneColor("7591 U", "#c98b77")},
            {3895,  new PantoneColor("7592 C", "#b65332")},
            {3896,  new PantoneColor("7592 U", "#b87060")},
            {3897,  new PantoneColor("7593 C", "#a2402a")},
            {3898,  new PantoneColor("7593 U", "#a46659")},
            {3899,  new PantoneColor("7594 C", "#7f382b")},
            {3900,  new PantoneColor("7594 U", "#8c6259")},
            {3901,  new PantoneColor("7595 C", "#6e3c2e")},
            {3902,  new PantoneColor("7595 U", "#81655c")},
            {3903,  new PantoneColor("7596 C", "#5e3c31")},
            {3904,  new PantoneColor("7596 U", "#77655f")},
            {3905,  new PantoneColor("7597 C", "#d73f22")},
            {3906,  new PantoneColor("7597 U", "#db6655")},
            {3907,  new PantoneColor("7598 C", "#c24628")},
            {3908,  new PantoneColor("7598 U", "#c66b5a")},
            {3909,  new PantoneColor("7599 C", "#b73c24")},
            {3910,  new PantoneColor("7599 U", "#c0685a")},
            {3911,  new PantoneColor("7600 C", "#903e2a")},
            {3912,  new PantoneColor("7600 U", "#9d685d")},
            {3913,  new PantoneColor("7601 C", "#85412a")},
            {3914,  new PantoneColor("7601 U", "#93685b")},
            {3915,  new PantoneColor("7602 C", "#7d4930")},
            {3916,  new PantoneColor("7602 U", "#8d6e60")},
            {3917,  new PantoneColor("7603 C", "#69412f")},
            {3918,  new PantoneColor("7603 U", "#7c665c")},
            {3919,  new PantoneColor("7604 C", "#e7d4d2")},
            {3920,  new PantoneColor("7604 U", "#ebd6d4")},
            {3921,  new PantoneColor("7605 C", "#e5b9b3")},
            {3922,  new PantoneColor("7605 U", "#ecc3bd")},
            {3923,  new PantoneColor("7606 C", "#dc9089")},
            {3924,  new PantoneColor("7606 U", "#e39e99")},
            {3925,  new PantoneColor("7607 C", "#c86b60")},
            {3926,  new PantoneColor("7607 U", "#cf857f")},
            {3927,  new PantoneColor("7608 C", "#a9473c")},
            {3928,  new PantoneColor("7608 U", "#af6c66")},
            {3929,  new PantoneColor("7609 C", "#873934")},
            {3930,  new PantoneColor("7609 U", "#95645f")},
            {3931,  new PantoneColor("7610 C", "#6b3230")},
            {3932,  new PantoneColor("7610 U", "#81605c")},
            {3933,  new PantoneColor("7611 C", "#e1bbaf")},
            {3934,  new PantoneColor("7611 U", "#e8c7bd")},
            {3935,  new PantoneColor("7612 C", "#cd998d")},
            {3936,  new PantoneColor("7612 U", "#d5a99f")},
            {3937,  new PantoneColor("7613 C", "#bf887e")},
            {3938,  new PantoneColor("7613 U", "#c89e96")},
            {3939,  new PantoneColor("7614 C", "#a67e73")},
            {3940,  new PantoneColor("7614 U", "#af928b")},
            {3941,  new PantoneColor("7615 C", "#896760")},
            {3942,  new PantoneColor("7615 U", "#978380")},
            {3943,  new PantoneColor("7616 C", "#6d4b4b")},
            {3944,  new PantoneColor("7616 U", "#867372")},
            {3945,  new PantoneColor("7617 C", "#5a3c3c")},
            {3946,  new PantoneColor("7617 U", "#746464")},
            {3947,  new PantoneColor("7618 C", "#cc6c4e")},
            {3948,  new PantoneColor("7618 U", "#d48876")},
            {3949,  new PantoneColor("7619 C", "#c74a37")},
            {3950,  new PantoneColor("7619 U", "#cb6f63")},
            {3951,  new PantoneColor("7620 C", "#bd2e2a")},
            {3952,  new PantoneColor("7620 U", "#c55e59")},
            {3953,  new PantoneColor("7621 C", "#b21e27")},
            {3954,  new PantoneColor("7621 U", "#bf5b5a")},
            {3955,  new PantoneColor("7622 C", "#97252b")},
            {3956,  new PantoneColor("7622 U", "#a85c5c")},
            {3957,  new PantoneColor("7623 C", "#8f2829")},
            {3958,  new PantoneColor("7623 U", "#9f5a57")},
            {3959,  new PantoneColor("7624 C", "#852c2b")},
            {3960,  new PantoneColor("7624 U", "#8f5854")},
            {3961,  new PantoneColor("7625 C", "#e94e3c")},
            {3962,  new PantoneColor("7625 U", "#f0756c")},
            {3963,  new PantoneColor("7626 C", "#cb3524")},
            {3964,  new PantoneColor("7626 U", "#d5625c")},
            {3965,  new PantoneColor("7627 C", "#ab2b28")},
            {3966,  new PantoneColor("7627 U", "#b05856")},
            {3967,  new PantoneColor("7628 C", "#a22929")},
            {3968,  new PantoneColor("7628 U", "#a95957")},
            {3969,  new PantoneColor("7629 C", "#703231")},
            {3970,  new PantoneColor("7629 U", "#805b59")},
            {3971,  new PantoneColor("7630 C", "#65312f")},
            {3972,  new PantoneColor("7630 U", "#765856")},
            {3973,  new PantoneColor("7631 C", "#592d2b")},
            {3974,  new PantoneColor("7631 U", "#6e5552")},
            {3975,  new PantoneColor("7632 C", "#d8c9ca")},
            {3976,  new PantoneColor("7632 U", "#ddcecf")},
            {3977,  new PantoneColor("7633 C", "#c8a3a6")},
            {3978,  new PantoneColor("7633 U", "#cba9ad")},
            {3979,  new PantoneColor("7634 C", "#c66583")},
            {3980,  new PantoneColor("7634 U", "#cb7b90")},
            {3981,  new PantoneColor("7635 C", "#cd3161")},
            {3982,  new PantoneColor("7635 U", "#d1607b")},
            {3983,  new PantoneColor("7636 C", "#c41a49")},
            {3984,  new PantoneColor("7636 U", "#c8546d")},
            {3985,  new PantoneColor("7637 C", "#962c45")},
            {3986,  new PantoneColor("7637 U", "#975764")},
            {3987,  new PantoneColor("7638 C", "#832b40")},
            {3988,  new PantoneColor("7638 U", "#87555f")},
            {3989,  new PantoneColor("7639 C", "#956c72")},
            {3990,  new PantoneColor("7639 U", "#a08489")},
            {3991,  new PantoneColor("7640 C", "#973e53")},
            {3992,  new PantoneColor("7640 U", "#9d6572")},
            {3993,  new PantoneColor("7641 C", "#932a47")},
            {3994,  new PantoneColor("7641 U", "#9c5c6c")},
            {3995,  new PantoneColor("7642 C", "#752d49")},
            {3996,  new PantoneColor("7642 U", "#805666")},
            {3997,  new PantoneColor("7643 C", "#692c43")},
            {3998,  new PantoneColor("7643 U", "#7a5966")},
            {3999,  new PantoneColor("7644 C", "#5a2c3e")},
            {4000,  new PantoneColor("7644 U", "#725762")},
            {4001,  new PantoneColor("7645 C", "#522a38")},
            {4002,  new PantoneColor("7645 U", "#6c565f")},
            {4003,  new PantoneColor("7646 C", "#a96c86")},
            {4004,  new PantoneColor("7646 U", "#b38599")},
            {4005,  new PantoneColor("7647 C", "#ad3b72")},
            {4006,  new PantoneColor("7647 U", "#b46889")},
            {4007,  new PantoneColor("7648 C", "#9e1b64")},
            {4008,  new PantoneColor("7648 U", "#a1537b")},
            {4009,  new PantoneColor("7649 C", "#8e195f")},
            {4010,  new PantoneColor("7649 U", "#965278")},
            {4011,  new PantoneColor("7650 C", "#762056")},
            {4012,  new PantoneColor("7650 U", "#855472")},
            {4013,  new PantoneColor("7651 C", "#6d295a")},
            {4014,  new PantoneColor("7651 U", "#805b77")},
            {4015,  new PantoneColor("7652 C", "#612550")},
            {4016,  new PantoneColor("7652 U", "#74546b")},
            {4017,  new PantoneColor("7653 C", "#978693")},
            {4018,  new PantoneColor("7653 U", "#9d939e")},
            {4019,  new PantoneColor("7654 C", "#a6769a")},
            {4020,  new PantoneColor("7654 U", "#ac88a5")},
            {4021,  new PantoneColor("7655 C", "#a55a95")},
            {4022,  new PantoneColor("7655 U", "#ab779e")},
            {4023,  new PantoneColor("7656 C", "#93397f")},
            {4024,  new PantoneColor("7656 U", "#97638c")},
            {4025,  new PantoneColor("7657 C", "#702b62")},
            {4026,  new PantoneColor("7657 U", "#7f5876")},
            {4027,  new PantoneColor("7658 C", "#6d335e")},
            {4028,  new PantoneColor("7658 U", "#7c5d75")},
            {4029,  new PantoneColor("7659 C", "#5f3552")},
            {4030,  new PantoneColor("7659 U", "#6f596b")},
            {4031,  new PantoneColor("7660 C", "#9b8fa2")},
            {4032,  new PantoneColor("7660 U", "#9d95a8")},
            {4033,  new PantoneColor("7661 C", "#906c95")},
            {4034,  new PantoneColor("7661 U", "#957d9b")},
            {4035,  new PantoneColor("7662 C", "#7d4081")},
            {4036,  new PantoneColor("7662 U", "#86658b")},
            {4037,  new PantoneColor("7663 C", "#6d3075")},
            {4038,  new PantoneColor("7663 U", "#7b5c82")},
            {4039,  new PantoneColor("7664 C", "#683177")},
            {4040,  new PantoneColor("7664 U", "#765c83")},
            {4041,  new PantoneColor("7665 C", "#62366e")},
            {4042,  new PantoneColor("7665 U", "#735d7b")},
            {4043,  new PantoneColor("7666 C", "#5e4d62")},
            {4044,  new PantoneColor("7666 U", "#716876")},
            {4045,  new PantoneColor("7667 C", "#6f7ba0")},
            {4046,  new PantoneColor("7667 U", "#828ba8")},
            {4047,  new PantoneColor("7668 C", "#696d9f")},
            {4048,  new PantoneColor("7668 U", "#7b7fa3")},
            {4049,  new PantoneColor("7669 C", "#635d9b")},
            {4050,  new PantoneColor("7669 U", "#7777a1")},
            {4051,  new PantoneColor("7670 C", "#585094")},
            {4052,  new PantoneColor("7670 U", "#6f6d99")},
            {4053,  new PantoneColor("7671 C", "#544487")},
            {4054,  new PantoneColor("7671 U", "#6d6892")},
            {4055,  new PantoneColor("7672 C", "#4e4084")},
            {4056,  new PantoneColor("7672 U", "#6b658d")},
            {4057,  new PantoneColor("7673 C", "#545386")},
            {4058,  new PantoneColor("7673 U", "#6c6c8c")},
            {4059,  new PantoneColor("7674 C", "#8a8ab3")},
            {4060,  new PantoneColor("7674 U", "#9194b7")},
            {4061,  new PantoneColor("7675 C", "#7e7eaa")},
            {4062,  new PantoneColor("7675 U", "#868aae")},
            {4063,  new PantoneColor("7676 C", "#77649f")},
            {4064,  new PantoneColor("7676 U", "#8279a3")},
            {4065,  new PantoneColor("7677 C", "#725090")},
            {4066,  new PantoneColor("7677 U", "#7d6c96")},
            {4067,  new PantoneColor("7678 C", "#6a478d")},
            {4068,  new PantoneColor("7678 U", "#756591")},
            {4069,  new PantoneColor("7679 C", "#583c80")},
            {4070,  new PantoneColor("7679 U", "#6f618a")},
            {4071,  new PantoneColor("7680 C", "#543177")},
            {4072,  new PantoneColor("7680 U", "#69587f")},
            {4073,  new PantoneColor("7681 C", "#95a7cb")},
            {4074,  new PantoneColor("7681 U", "#9aaed0")},
            {4075,  new PantoneColor("7682 C", "#6986b7")},
            {4076,  new PantoneColor("7682 U", "#7f96c0")},
            {4077,  new PantoneColor("7683 C", "#446ba8")},
            {4078,  new PantoneColor("7683 U", "#6681ae")},
            {4079,  new PantoneColor("7684 C", "#365d9d")},
            {4080,  new PantoneColor("7684 U", "#6075a3")},
            {4081,  new PantoneColor("7685 C", "#2e5596")},
            {4082,  new PantoneColor("7685 U", "#5c709c")},
            {4083,  new PantoneColor("7686 C", "#1d4e8f")},
            {4084,  new PantoneColor("7686 U", "#536895")},
            {4085,  new PantoneColor("7687 C", "#1d4189")},
            {4086,  new PantoneColor("7687 U", "#4f5e8c")},
            {4087,  new PantoneColor("7688 C", "#4497cb")},
            {4088,  new PantoneColor("7688 U", "#5a98ca")},
            {4089,  new PantoneColor("7689 C", "#288dc0")},
            {4090,  new PantoneColor("7689 U", "#5292c2")},
            {4091,  new PantoneColor("7690 C", "#0075a8")},
            {4092,  new PantoneColor("7690 U", "#477ea7")},
            {4093,  new PantoneColor("7691 C", "#006097")},
            {4094,  new PantoneColor("7691 U", "#447097")},
            {4095,  new PantoneColor("7692 C", "#005486")},
            {4096,  new PantoneColor("7692 U", "#4a6a8c")},
            {4097,  new PantoneColor("7693 C", "#004876")},
            {4098,  new PantoneColor("7693 U", "#4a6381")},
            {4099,  new PantoneColor("7694 U", "#4c5f78")},
            {4100,  new PantoneColor("7695 C", "#7ca5ba")},
            {4101,  new PantoneColor("7695 U", "#80a7bc")},
            {4102,  new PantoneColor("7696 C", "#6199ae")},
            {4103,  new PantoneColor("7696 U", "#6e9aae")},
            {4104,  new PantoneColor("7697 C", "#4e869f")},
            {4105,  new PantoneColor("7697 U", "#688ea3")},
            {4106,  new PantoneColor("7698 C", "#41738c")},
            {4107,  new PantoneColor("7698 U", "#637e91")},
            {4108,  new PantoneColor("7699 C", "#35647d")},
            {4109,  new PantoneColor("7699 U", "#5c7588")},
            {4110,  new PantoneColor("7700 C", "#1c5a7c")},
            {4111,  new PantoneColor("7700 U", "#547088")},
            {4112,  new PantoneColor("7701 C", "#005677")},
            {4113,  new PantoneColor("7701 U", "#45697f")},
            {4114,  new PantoneColor("7702 C", "#45a7c5")},
            {4115,  new PantoneColor("7702 U", "#5aa8c7")},
            {4116,  new PantoneColor("7703 C", "#009abe")},
            {4117,  new PantoneColor("7703 U", "#419ebf")},
            {4118,  new PantoneColor("7704 C", "#0083ac")},
            {4119,  new PantoneColor("7704 U", "#2f89ac")},
            {4120,  new PantoneColor("7705 C", "#006e96")},
            {4121,  new PantoneColor("7705 U", "#387b9a")},
            {4122,  new PantoneColor("7706 C", "#00698e")},
            {4123,  new PantoneColor("7706 U", "#407895")},
            {4124,  new PantoneColor("7707 C", "#005f7f")},
            {4125,  new PantoneColor("7707 U", "#437288")},
            {4126,  new PantoneColor("7708 C", "#00546f")},
            {4127,  new PantoneColor("7708 U", "#41697d")},
            {4128,  new PantoneColor("7709 C", "#63b0bb")},
            {4129,  new PantoneColor("7709 U", "#6ab0bc")},
            {4130,  new PantoneColor("7710 C", "#00a5b5")},
            {4131,  new PantoneColor("7710 U", "#39a8b8")},
            {4132,  new PantoneColor("7711 C", "#0095a8")},
            {4133,  new PantoneColor("7711 U", "#009bac")},
            {4134,  new PantoneColor("7712 C", "#00829a")},
            {4135,  new PantoneColor("7712 U", "#1e899d")},
            {4136,  new PantoneColor("7713 C", "#007a89")},
            {4137,  new PantoneColor("7713 U", "#258492")},
            {4138,  new PantoneColor("7714 C", "#00747f")},
            {4139,  new PantoneColor("7714 U", "#2e7f8a")},
            {4140,  new PantoneColor("7715 C", "#006067")},
            {4141,  new PantoneColor("7715 U", "#3f6f77")},
            {4142,  new PantoneColor("7716 C", "#00948f")},
            {4143,  new PantoneColor("7716 U", "#439796")},
            {4144,  new PantoneColor("7717 C", "#00827d")},
            {4145,  new PantoneColor("7717 U", "#378c8b")},
            {4146,  new PantoneColor("7718 C", "#007473")},
            {4147,  new PantoneColor("7718 U", "#308082")},
            {4148,  new PantoneColor("7719 C", "#006b67")},
            {4149,  new PantoneColor("7719 U", "#3c7979")},
            {4150,  new PantoneColor("7720 C", "#00615b")},
            {4151,  new PantoneColor("7720 U", "#437575")},
            {4152,  new PantoneColor("7721 C", "#005c5c")},
            {4153,  new PantoneColor("7721 U", "#477174")},
            {4154,  new PantoneColor("7722 C", "#004f50")},
            {4155,  new PantoneColor("7722 U", "#48696e")},
            {4156,  new PantoneColor("7723 C", "#4ea585")},
            {4157,  new PantoneColor("7723 U", "#67aa91")},
            {4158,  new PantoneColor("7724 C", "#00946d")},
            {4159,  new PantoneColor("7724 U", "#4c9980")},
            {4160,  new PantoneColor("7725 C", "#008555")},
            {4161,  new PantoneColor("7725 U", "#358f71")},
            {4162,  new PantoneColor("7726 C", "#007a4b")},
            {4163,  new PantoneColor("7726 U", "#328369")},
            {4164,  new PantoneColor("7727 C", "#006d45")},
            {4165,  new PantoneColor("7727 U", "#3b7a64")},
            {4166,  new PantoneColor("7728 C", "#006645")},
            {4167,  new PantoneColor("7728 U", "#427665")},
            {4168,  new PantoneColor("7729 C", "#005744")},
            {4169,  new PantoneColor("7729 U", "#456e67")},
            {4170,  new PantoneColor("7730 C", "#4b9461")},
            {4171,  new PantoneColor("7730 U", "#659979")},
            {4172,  new PantoneColor("7731 C", "#208648")},
            {4173,  new PantoneColor("7731 U", "#55906b")},
            {4174,  new PantoneColor("7732 C", "#00783e")},
            {4175,  new PantoneColor("7732 U", "#468364")},
            {4176,  new PantoneColor("7733 C", "#006e42")},
            {4177,  new PantoneColor("7733 U", "#497a62")},
            {4178,  new PantoneColor("7734 C", "#286040")},
            {4179,  new PantoneColor("7734 U", "#567564")},
            {4180,  new PantoneColor("7735 C", "#37563c")},
            {4181,  new PantoneColor("7735 U", "#5f6f62")},
            {4182,  new PantoneColor("7736 C", "#385441")},
            {4183,  new PantoneColor("7736 U", "#5a6a62")},
            {4184,  new PantoneColor("7737 C", "#6ca438")},
            {4185,  new PantoneColor("7737 U", "#79aa66")},
            {4186,  new PantoneColor("7738 C", "#46a040")},
            {4187,  new PantoneColor("7738 U", "#63a768")},
            {4188,  new PantoneColor("7739 C", "#2e9941")},
            {4189,  new PantoneColor("7739 U", "#58a26a")},
            {4190,  new PantoneColor("7740 C", "#368f3f")},
            {4191,  new PantoneColor("7740 U", "#5a9665")},
            {4192,  new PantoneColor("7741 C", "#41873e")},
            {4193,  new PantoneColor("7741 U", "#649166")},
            {4194,  new PantoneColor("7742 C", "#48763a")},
            {4195,  new PantoneColor("7742 U", "#648464")},
            {4196,  new PantoneColor("7743 C", "#41683b")},
            {4197,  new PantoneColor("7743 U", "#5c735d")},
            {4198,  new PantoneColor("7744 C", "#babb13")},
            {4199,  new PantoneColor("7744 U", "#b8bc55")},
            {4200,  new PantoneColor("7745 C", "#abac21")},
            {4201,  new PantoneColor("7745 U", "#aeb25c")},
            {4202,  new PantoneColor("7746 C", "#9b9a30")},
            {4203,  new PantoneColor("7746 U", "#9b9e5f")},
            {4204,  new PantoneColor("7747 C", "#8a8c30")},
            {4205,  new PantoneColor("7747 U", "#8f9561")},
            {4206,  new PantoneColor("7748 C", "#7e7f34")},
            {4207,  new PantoneColor("7748 U", "#878b62")},
            {4208,  new PantoneColor("7749 C", "#737335")},
            {4209,  new PantoneColor("7749 U", "#7f8261")},
            {4210,  new PantoneColor("7750 C", "#666534")},
            {4211,  new PantoneColor("7750 U", "#767960")},
            {4212,  new PantoneColor("7751 C", "#cbb44a")},
            {4213,  new PantoneColor("7751 U", "#d1bc71")},
            {4214,  new PantoneColor("7752 C", "#d1ae1e")},
            {4215,  new PantoneColor("7752 U", "#d6b761")},
            {4216,  new PantoneColor("7753 C", "#c3a01c")},
            {4217,  new PantoneColor("7753 U", "#c6aa5c")},
            {4218,  new PantoneColor("7754 C", "#a28527")},
            {4219,  new PantoneColor("7754 U", "#a4905d")},
            {4220,  new PantoneColor("7755 C", "#8b752f")},
            {4221,  new PantoneColor("7755 U", "#90845f")},
            {4222,  new PantoneColor("7756 C", "#746635")},
            {4223,  new PantoneColor("7756 U", "#837c61")},
            {4224,  new PantoneColor("7757 C", "#695d31")},
            {4225,  new PantoneColor("7757 U", "#79745f")},
            {4226,  new PantoneColor("7758 C", "#d6c200")},
            {4227,  new PantoneColor("7758 U", "#dac856")},
            {4228,  new PantoneColor("7759 C", "#c6b200")},
            {4229,  new PantoneColor("7759 U", "#c8b751")},
            {4230,  new PantoneColor("7760 C", "#93832b")},
            {4231,  new PantoneColor("7760 U", "#958e5e")},
            {4232,  new PantoneColor("7761 C", "#757034")},
            {4233,  new PantoneColor("7761 U", "#828060")},
            {4234,  new PantoneColor("7762 C", "#5e6338")},
            {4235,  new PantoneColor("7762 U", "#727862")},
            {4236,  new PantoneColor("7763 C", "#5a5b3a")},
            {4237,  new PantoneColor("7763 U", "#707362")},
            {4238,  new PantoneColor("7764 C", "#545333")},
            {4239,  new PantoneColor("7764 U", "#6c6d5f")},
            {4240,  new PantoneColor("7765 C", "#bbb21e")},
            {4241,  new PantoneColor("7765 U", "#c0b95e")},
            {4242,  new PantoneColor("7766 C", "#b5a81b")},
            {4243,  new PantoneColor("7766 U", "#bcb25e")},
            {4244,  new PantoneColor("7767 C", "#ab9c2c")},
            {4245,  new PantoneColor("7767 U", "#b1a561")},
            {4246,  new PantoneColor("7768 C", "#8e7e33")},
            {4247,  new PantoneColor("7768 U", "#948b61")},
            {4248,  new PantoneColor("7769 C", "#726032")},
            {4249,  new PantoneColor("7769 U", "#80775d")},
            {4250,  new PantoneColor("7770 C", "#645937")},
            {4251,  new PantoneColor("7770 U", "#76715f")},
            {4252,  new PantoneColor("7771 C", "#4f4932")},
            {4253,  new PantoneColor("7771 U", "#666359")},
            {4254,  new PantoneColor("801", "#00aacc")},
            {4255,  new PantoneColor("802", "#60dd49")},
            {4256,  new PantoneColor("803", "#ffed38")},
            {4257,  new PantoneColor("804", "#ff9338")},
            {4258,  new PantoneColor("805", "#f95951")},
            {4259,  new PantoneColor("806", "#ff0093")},
            {4260,  new PantoneColor("807", "#d6009e")},
            {4261,  new PantoneColor("808", "#00b59b")},
            {4262,  new PantoneColor("809", "#dde00f")},
            {4263,  new PantoneColor("810", "#ffcc1e")},
            {4264,  new PantoneColor("811", "#ff7247")},
            {4265,  new PantoneColor("812", "#fc2366")},
            {4266,  new PantoneColor("813", "#e50099")},
            {4267,  new PantoneColor("814", "#8c60c1")},
            {4268,  new PantoneColor("Black 2 C    ", "#332e1f")},
            {4269,  new PantoneColor("Black 2 U    ", "#625f51")},
            {4270,  new PantoneColor("Black 3 C    ", "#212620")},
            {4271,  new PantoneColor("Black 3 U    ", "#575c58")},
            {4272,  new PantoneColor("Black 4 C    ", "#31251c")},
            {4273,  new PantoneColor("Black 4 U    ", "#685f54")},
            {4274,  new PantoneColor("Black 5 C    ", "#3f2a2e")},
            {4275,  new PantoneColor("Black 5 U    ", "#68595b")},
            {4276,  new PantoneColor("Black 6 C    ", "#10181f")},
            {4277,  new PantoneColor("Black 6 U    ", "#4a4d56")},
            {4278,  new PantoneColor("Black 7 C    ", "#3d3834")},
            {4279,  new PantoneColor("Black 7 U    ", "#6d6763")},
            {4280,  new PantoneColor("Black C    ", "#2e2925")},
            {4281,  new PantoneColor("Black U    ", "#615c59")},
            {4282,  new PantoneColor("Blue 072 C", "#050d9e")},
            {4283,  new PantoneColor("Blue 072 U", "#3943ac")},
            {4284,  new PantoneColor("Bright Red C", "#f93822")},
            {4285,  new PantoneColor("Cool Gray 1 C", "#dad8d6")},
            {4286,  new PantoneColor("Cool Gray 10 C", "#646469")},
            {4287,  new PantoneColor("Cool Gray 10 U", "#7f8286")},
            {4288,  new PantoneColor("Cool Gray 11 C", "#555559")},
            {4289,  new PantoneColor("Cool Gray 11 U", "#797c80")},
            {4290,  new PantoneColor("Cool Gray 2 C", "#d2cfcd")},
            {4291,  new PantoneColor("Cool Gray 2 U", "#cac9c8")},
            {4292,  new PantoneColor("Cool Gray 3 U", "#c5c3c3")},
            {4293,  new PantoneColor("Cool Gray 4 C", "#bcbbba")},
            {4294,  new PantoneColor("Cool Gray 4 U", "#b7b6b8")},
            {4295,  new PantoneColor("Cool Gray 5 C", "#b3b1b1")},
            {4296,  new PantoneColor("Cool Gray 5 U", "#abaeb0")},
            {4297,  new PantoneColor("Cool Gray 6 C", "#a9a8a9")},
            {4298,  new PantoneColor("Cool Gray 6 U", "#a2a4a6")},
            {4299,  new PantoneColor("Cool Gray 7 C", "#999899")},
            {4300,  new PantoneColor("Cool Gray 8 C", "#8a8a8d")},
            {4301,  new PantoneColor("Cool Gray 8 U", "#919498")},
            {4302,  new PantoneColor("Cool Gray 9 C", "#777779")},
            {4303,  new PantoneColor("Cool Gray 9 U", "#878a8e")},
            {4304,  new PantoneColor("Green C", "#00a887")},
            {4305,  new PantoneColor("Green U", "#00a88e")},
            {4306,  new PantoneColor("Orange 021 C", "#ff5000")},
            {4307,  new PantoneColor("Orange 021 U", "#ff6d2e")},
            {4308,  new PantoneColor("Pink C", "#d62598")},
            {4309,  new PantoneColor("Process Blue C", "#0081c9")},
            {4310,  new PantoneColor("Process Blue U", "#0081c4")},
            {4311,  new PantoneColor("Purple C", "#c126b8")},
            {4312,  new PantoneColor("Purple U", "#c252b4")},
            {4313,  new PantoneColor("Red 032 C", "#f6323e")},
            {4314,  new PantoneColor("Red 032 U", "#fd4f57")},
            {4315,  new PantoneColor("Reflex Blue C", "#001588")},
            {4316,  new PantoneColor("Reflex Blue U", "#38499b")},
            {4317,  new PantoneColor("Rhodamine Red C", "#e70094")},
            {4318,  new PantoneColor("Rhodamine Red U", "#e94b97")},
            {4319,  new PantoneColor("Rubine Red C", "#d60056")},
            {4320,  new PantoneColor("Rubine Red U", "#e1457c")},
            {4321,  new PantoneColor("Violet C", "#430098")},
            {4322,  new PantoneColor("Violet U", "#7459b1")},
            {4323,  new PantoneColor("Warm Gray 1 C", "#d8d1c9")},
            {4324,  new PantoneColor("Warm Gray 1 U", "#dbd4cd")},
            {4325,  new PantoneColor("Warm Gray 10 C", "#7b6d65")},
            {4326,  new PantoneColor("Warm Gray 10 U", "#827a78")},
            {4327,  new PantoneColor("Warm Gray 11 C", "#706258")},
            {4328,  new PantoneColor("Warm Gray 11 U", "#7d7573")},
            {4329,  new PantoneColor("Warm Gray 2 C", "#cdc3bb")},
            {4330,  new PantoneColor("Warm Gray 2 U", "#cec7c0")},
            {4331,  new PantoneColor("Warm Gray 3 C", "#c1b7af")},
            {4332,  new PantoneColor("Warm Gray 3 U", "#beb5af")},
            {4333,  new PantoneColor("Warm Gray 4 C", "#b6ada4")},
            {4334,  new PantoneColor("Warm Gray 4 U", "#b3aaa4")},
            {4335,  new PantoneColor("Warm Gray 5 C", "#aea198")},
            {4336,  new PantoneColor("Warm Gray 5 U", "#a8a09b")},
            {4337,  new PantoneColor("Warm Gray 6 U", "#a29a95")},
            {4338,  new PantoneColor("Warm Gray 7 C", "#978b82")},
            {4339,  new PantoneColor("Warm Gray 7 U", "#978e8a")},
            {4340,  new PantoneColor("Warm Gray 8 C", "#8e8279")},
            {4341,  new PantoneColor("Warm Gray 8 U", "#8e8682")},
            {4342,  new PantoneColor("Warm Gray 9 C", "#85776f")},
            {4343,  new PantoneColor("Warm Gray 9 U", "#867e7c")},
            {4344,  new PantoneColor("Warm Red C", "#ff4337")},
            {4345,  new PantoneColor("Warm Red U", "#ff665b")},
            {4346,  new PantoneColor("Yellow 012 C", "#ffd700")},
            {4347,  new PantoneColor("Yellow C", "#ffdd00")}
        };
 //100	 			#f4ed7c			
 //100 C				#f7ea5f			
 //100 U				#fef27e			
 //101				#f4ed47			
 //101 C				#f8e946			
 //101 U				#ffef65			
 //102				#f9e814			
 //102 C				#fde300			
 //102 U				#ffec28			
 //103				#c6ad0f			
 //103 C				#c6a900			
 //103 U				#b59e28			
 //104				#ad9b0c			
 //104 C				#b19700			
 //104 U				#9b8c37			
 //105				#82750f			
 //105 C				#8b7a27			
 //105 U				#7d7446			
 //106				#f7e859			
 //106 C				#fbe343			
 //106 U				#ffea65			
 //107				#f9e526			
 //107 C				#fee01e			
 //107 U				#ffe450			
 //108				#f9dd16			
 //108 U				#ffdc32			
 //109				#f9d616			
 //109 C				#ffd100			
 //109 U				#ffc700			
 //110				#d8b511			
 //110 C				#dba900			
 //110 U				#cd9f24			
 //111				#aa930a			
 //111 C				#ac8900			
 //111 U				#9b8638			
 //112				#99840a			
 //112 C				#9d830f			
 //112 U				#8a7a3e			
 //113				#f9e55b			
 //113 C				#fddf50			
 //113 U				#ffe05e			
 //114				#f9e24c			
 //114 C				#fedd3c			
 //114 U				#ffd847			
 //115				#f9e04c			
 //115 C				#ffd923			
 //115 U				#ffcd29			
 //116				#fcd116			
 //116 C				#ffcd00			
 //116 U				#ffb408			
 //117				#c6a00c			
 //117 C				#cc9700			
 //117 U				#b78b2e			
 //118				#aa8e0a			
 //118 C				#ae8400			
 //118 U				#9e8038			
 //119				#897719			
 //119 C				#8a731f			
 //119 U				#847647			
 //120				#f9e27f			
 //120 C				#feda63			
 //120 U				#ffd968			
 //1205				#f7e8aa			
 //1205 C				#f9df8d			
 //1205 U				#ffe394			
 //121				#f9e070			
 //121 C				#ffd755			
 //121 U				#ffcb50			
 //1215				#f9e08c			
 //1215 C				#fed671			
 //1215 U				#ffd97c			
 //122				#fcd856			
 //122 C				#ffd03e			
 //122 U				#ffc03d			
 //1225				#ffcc49			
 //1225 C				#ffc842			
 //1225 U				#ffba4d			
 //123				#ffc61e			
 //123 C				#ffc627			
 //123 U				#ffac25			
 //1235				#fcb514			
 //1235 C				#ffb718			
 //1235 U				#ffad38			
 //124				#e0aa0f			
 //124 C				#eda900			
 //124 U				#d99132			
 //1245				#bf910c			
 //1245 C				#c9910d			
 //1245 U				#bb8a3f			
 //125				#b58c0a			
 //125 C				#b78400			
 //125 U				#a6803a			
 //1255				#a37f14			
 //1255 C				#af841d			
 //1255 U				#a18045			
 //126				#a38205			
 //126 C				#9d760c			
 //126 U				#8e7641			
 //1265				#7c6316			
 //1265 C				#8a6b24			
 //1265 U				#887447			
 //127				#f4e287			
 //127 C				#f5db6b			
 //127 U				#fce182			
 //128				#f4db60			
 //128 C				#f7d44b			
 //128 U				#fecd60			
 //129				#f2d13d			
 //129 C				#f6ce3c			
 //129 U				#fead3c			
 //130				#eaaf0f			
 //130 C				#f7a700			
 //130 U				#fc992e			
 //131				#c6930a			
 //131 C				#d08900			
 //131 U				#be7e33			
 //132				#9e7c0a			
 //132 C				#a37300			
 //132 U				#99793d			
 //133				#705b0a			
 //133 C				#6e561b			
 //133 U				#7c6f46			
 //134				#ffd87f			
 //134 C				#ffd16c			
 //134 U				#ffd276			
 //1345				#ffd691			
 //1345 C				#fecf84			
 //1345 U				#ffd490			
 //135				#fcc963			
 //135 C				#ffc556			
 //135 U				#ffc265			
 //1355				#fcce87			
 //1355 C				#ffc56c			
 //1355 U				#ffc87e			
 //136				#fcbf49			
 //136 C				#ffbf3b			
 //136 U				#ffac48			
 //1365				#fcba5e			
 //1365 C				#ffb546			
 //1365 U				#ffac5a			
 //137				#fca311			
 //137 C				#ffa300			
 //137 U				#ffa035			
 //1375				#f99b0c			
 //1375 C				#ff9e15			
 //1375 U				#ff993e			
 //138				#d88c02			
 //138 C				#e17c00			
 //138 U				#d57b2f			
 //1385				#cc7a02			
 //1385 C				#d87800			
 //1385 U				#cf7d3d			
 //139				#af7505			
 //139 C				#b26d00			
 //139 U				#9e6e3c			
 //1395				#996007			
 //1395 C				#9c5f15			
 //1395 U				#956d42			
 //140				#7a5b11			
 //140 C				#755319			
 //140 U				#806944			
 //1405				#6b4714			
 //1405 C				#704b1c			
 //1405 U				#7a6446			
 //141				#f2ce68			
 //141 C				#f6c55b			
 //141 U				#fbbf6d			
 //142				#f2bf49			
 //142 C				#f5bd47			
 //142 U				#fbae5c			
 //143				#efb22d			
 //143 C				#f6b333			
 //143 U				#fb9e4e			
 //144				#e28c05			
 //144 C				#f38a00			
 //144 U				#f78a3b			
 //145				#c67f07			
 //145 C				#d57e00			
 //145 U				#cc7d38			
 //146				#9e6b05			
 //146 C				#ab6b0e			
 //146 U				#9e7340			
 //147				#725e26			
 //147 C				#735b28			
 //147 U				#776849			
 //148				#ffd69b			
 //148 C				#ffcb8a			
 //148 U				#ffc586			
 //1485				#ffb777			
 //1485 C				#ffad5e			
 //1485 U				#ffa660			
 //149				#fccc93			
 //149 C				#ffc27a			
 //149 U				#ffb573			
 //1495				#ff993f			
 //1495 C				#ff8f12			
 //1495 U				#ff934e			
 //150				#fcad56			
 //150 C				#ffb258			
 //150 U				#ff9954			
 //1505				#f47c00			
 //1505 C				#ff6a00			
 //1505 U				#ff8135			
 //151				#f77f00			
 //151 C				#ff8300			
 //151 U				#ff873b			
 //152				#dd7500			
 //152 C				#e97200			
 //152 U				#e3793d			
 //1525				#b55400			
 //1525 C				#bd4600			
 //1525 U				#be6437			
 //153				#bc6d0a			
 //153 C				#c16a10			
 //153 U				#ad6e41			
 //1535				#8c4400			
 //1535 C				#974508			
 //1535 U				#976240			
 //154				#995905			
 //154 C				#9e5916			
 //154 U				#926743			
 //1545				#4c280f			
 //1545 C				#683816			
 //1545 U				#7b5e48			
 //155				#f4dbaa			
 //155 C				#f3d09e			
 //155 U				#fac895			
 //1555				#f9bf9e			
 //1555 C				#ffb98d			
 //1555 U				#ffc29c			
 //156				#f2c68c			
 //156 C				#f2bc7b			
 //156 U				#fbb883			
 //1565				#fca577			
 //1565 C				#ffa167			
 //1565 U				#ffaa81			
 //157				#eda04f			
 //157 C				#f19f53			
 //157 U				#f69462			
 //1575				#fc8744			
 //1575 C				#ff7e2e			
 //1575 U				#ff9562			
 //158				#e87511			
 //158 C				#ef7521			
 //158 U				#f37d4a			
 //1585				#f96b07			
 //1585 C				#ff6b0b			
 //1585 U				#ff844e			
 //159				#c66005			
 //159 C				#d25d12			
 //159 U				#cd6f46			
 //1595				#d15b05			
 //1595 C				#dc5f13			
 //1595 U				#d77045			
 //160				#9e540a			
 //160 C				#a5541a			
 //160 U				#a06a45			
 //1605				#a04f11			
 //1605 C				#a95521			
 //1605 U				#a86b4b			
 //161				#633a11			
 //161 C				#633c20			
 //161 U				#776149			
 //1615				#843f0f			
 //1615 C				#8e471e			
 //1615 U				#946449			
 //162				#f9c6aa			
 //162 C				#ffbe9e			
 //162 U				#ffba98			
 //1625				#f9a58c			
 //1625 C				#ffa388			
 //1625 U				#ffa88f			
 //163				#fc9e70			
 //163 C				#ff9d6b			
 //163 U				#ff9b75			
 //1635				#f98e6d			
 //1635 C				#ff8d6a			
 //1635 U				#ff967c			
 //164				#fc7f3f			
 //164 C				#ff7f3f			
 //164 U				#ff855d			
 //1645				#f97242			
 //1645 C				#ff6b35			
 //1645 U				#ff7f60			
 //165				#f96302			
 //165 C				#ff661b			
 //165 U				#ff7546			
 //1655				#f95602			
 //1655 C				#ff4c00			
 //1655 U				#ff704b			
 //166				#dd5900			
 //166 C				#e75200			
 //166 U				#e5653e			
 //1665				#dd4f05			
 //1665 C				#e24301			
 //1665 U				#e96847			
 //167				#bc4f07			
 //167 C				#c25219			
 //167 U				#b76546			
 //1675				#a53f0f			
 //1675 C				#ad431c			
 //1675 U				#ac6149			
 //168				#6d3011			
 //168 C				#75381b			
 //168 U				#8b614b			
 //1685				#843511			
 //1685 C				#86391f			
 //1685 U				#96604d			
 //169				#f9baaa			
 //169 C				#ffb4aa			
 //169 U				#ffb7ac			
 //170				#f98972			
 //170 C				#ff8671			
 //170 U				#ff8d7c			
 //171				#f9603a			
 //171 C				#ff5b34			
 //171 U				#ff7762			
 //172				#f74902			
 //172 C				#ff4611			
 //172 U				#ff674a			
 //173				#d14414			
 //173 C				#d3441c			
 //173 U				#d06149			
 //174				#933311			
 //174 C				#99381f			
 //174 U				#9d5b49			
 //175				#6d3321			
 //175 C				#6d3527			
 //175 U				#7e584c			
 //176				#f9afad			
 //176 C				#ffb1b8			
 //1765				#f99ea3			
 //1765 C				#ffa4b3			
 //1765 U				#ffa7b4			
 //1767				#f9b2b7			
 //1767 C				#ffafbf			
 //1767 U				#ffbac8			
 //177				#f9827f			
 //177 C				#ff8188			
 //177 U				#ff8c8f			
 //1775				#f9848e			
 //1775 C				#ff8e9e			
 //1775 U				#ff8b97			
 //1777				#fc6675			
 //1777 C				#ff637d			
 //1777 U				#ff808f			
 //178				#f95e59			
 //178 C				#ff5859			
 //178 U				#ff7675			
 //1785				#fc4f59			
 //1785 C				#ff485b			
 //1785 U				#ff6570			
 //1787				#f43f4f			
 //1787 C				#fb3448			
 //1787 U				#ff636f			
 //1788				#ef2b2d			
 //1788 C				#f42434			
 //1788 U				#fe5c61			
 //179				#e23d28			
 //179 C				#e53c2e			
 //179 U				#e55f53			
 //1795				#d62828			
 //1795 C				#d8262e			
 //1795 U				#dd5958			
 //1797				#cc2d30			
 //1797 C				#d03238			
 //1797 U				#ce4e51			
 //180				#c13828			
 //180 C				#c33a32			
 //180 U				#c06058			
 //1805				#af2626			
 //1805 C				#b3272d			
 //1805 U				#b65957			
 //1807				#a03033			
 //1807 C				#a83338			
 //1807 U				#a95051			
 //181				#7c2d23			
 //181 C				#84322c			
 //181 U				#8b5951			
 //1810				#7c211e			
 //1815 C				#802528			
 //1815 U				#905651			
 //1817				#5b2d28			
 //1817 C				#663233			
 //1817 U				#7a5352			
 //182				#f9bfc1			
 //182 C				#febbca			
 //182 U				#ffb8c8			
 //183				#fc8c99			
 //183 C				#ff9bb1			
 //183 U				#ff8da2			
 //184				#fc5e72			
 //184 C				#fc5272			
 //184 U				#ff6d82			
 //185				#e8112d			
 //185 C				#eb0028			
 //185 U				#f7505f			
 //186				#ce1126			
 //186 C				#cf0a2c			
 //186 U				#d6515d			
 //187				#af1e2d			
 //187 C				#ab162b			
 //187 U				#b15359			
 //188				#7c2128			
 //188 C				#79232e			
 //188 U				#8a5457			
 //189				#ffa3b2			
 //189 C				#fda3ba			
 //189 U				#ffabc0			
 //1895				#fcbfc9			
 //1895 C				#f8b5cc			
 //1895 U				#ffb3cc			
 //190				#fc758e			
 //190 C				#fb7497			
 //190 U				#ff87a1			
 //1905				#fc9bb2			
 //1905 C				#fa9aba			
 //1905 U				#ff9bb9			
 //191				#f4476b			
 //191 C				#f5416c			
 //191 U				#fc6e88			
 //1915				#f4547c			
 //1915 C				#f54b7f			
 //1915 U				#fb6f91			
 //192				#e5053a			
 //192 C				#ec0044			
 //192 U				#f45269			
 //1925				#e00747			
 //1925 C				#e9004b			
 //1925 U				#ee4e6c			
 //193				#db828c			
 //193 C				#c5093b			
 //193 U				#c95163			
 //1935				#c10538			
 //1935 C				#cb003c			
 //1935 U				#ce4b61			
 //194				#992135			
 //194 C				#a02741			
 //194 U				#a65863			
 //1945				#a80c35			
 //1945 C				#ac063c			
 //1945 U				#b35467			
 //195 C				#7b2f3e			
 //195 U				#895a61			
 //1955				#931638			
 //1955 C				#8f1336			
 //1955 U				#9a5261			
 //196				#f4c9c9			
 //196 C				#efc6cd			
 //196 U				#f7c2ca			
 //197				#ef99a3			
 //197 C				#ee9aac			
 //197 U				#f59fb1			
 //198				#772d35			
 //198 C				#e74260			
 //198 U				#ee687b			
 //199				#d81c3f			
 //199 C				#dc0031			
 //199 U				#e34d5f			
 //200				#c41e3a			
 //200 C				#c2002f			
 //200 U				#c24c5a			
 //2001 C				#f7e49a			
 //2001 U				#ffeb9f			
 //2002 C				#f9e17d			
 //2002 U				#ffe683			
 //2003 C				#fae167			
 //2003 U				#ffe774			
 //2004 C				#fbdc7a			
 //2004 U				#ffe17e			
 //2005 C				#fed781			
 //2005 U				#ffda82			
 //2006 C				#ecbc4d			
 //2006 U				#f2bf65			
 //2007 C				#e1a423			
 //2007 U				#e3a753			
 //2008 C				#f2be70			
 //2008 U				#fabc77			
 //2009 C				#f2b562			
 //2009 U				#fbaf6a			
 //201				#a32638			
 //201 C				#a31f34			
 //201 U				#a4565e			
 //2010 C				#ffad00			
 //2010 U				#ffb300			
 //2011 C				#f19933			
 //2011 U				#f89756			
 //2012 C				#f39500			
 //2012 U				#fb9841			
 //2013 C				#ff9800			
 //2013 U				#ffa01f			
 //2014 C				#bb7000			
 //2014 U				#bd823d			
 //2015 C				#f8cea6			
 //2015 U				#ffd9b5			
 //2016 C				#ffb771			
 //2016 U				#ffc286			
 //2017 C				#f8ad6a			
 //2017 U				#ffb77f			
 //2018 C				#ff7600			
 //2018 U				#ff8a3d			
 //2019 C				#da6c00			
 //2019 U				#e08449			
 //202				#8c2633			
 //202 C				#8b2331			
 //202 U				#92575d			
 //2020 C				#c05400			
 //2020 U				#c9713b			
 //2021 C				#9f4812			
 //2021 U				#a7633d			
 //2022 C				#feaa8c			
 //2022 U				#ffa98e			
 //2023 C				#fd936e			
 //2023 U				#ff9b7f			
 //2024 C				#fd7b55			
 //2024 U				#ff876e			
 //2025 C				#ff8a39			
 //2025 U				#ff955e			
 //2026 C				#fa6238			
 //2026 U				#ff755e			
 //2027 C				#f3523e			
 //2027 U				#fa6a62			
 //2028 C				#f13000			
 //2028 U				#f64f35			
 //2029 C				#f7817d			
 //2029 U				#fb8583			
 //203				#f2afc1			
 //203 C				#f0b2c9			
 //203 U				#f8b0cb			
 //2030 C				#e17973			
 //2030 U				#ea8c89			
 //2031 C				#da6764			
 //2031 U				#e07b7b			
 //2032 C				#d45856			
 //2032 U				#d77170			
 //2033 C				#ca4543			
 //2033 U				#cd6866			
 //2034 C				#ec3a3d			
 //2034 U				#f25f62			
 //2035 C				#dc001b			
 //2035 U				#e43f41			
 //2036 C				#f8bdd5			
 //2036 U				#ffc3da			
 //2037 C				#f695c5			
 //2037 U				#ff9bca			
 //2038 C				#f460a1			
 //2038 U				#f772a5			
 //2039 C				#ea3986			
 //2039 U				#ef5b8e			
 //204				#ed7a9e
 //204 C				#ec80a8	
 //204 U				#f481a4	
 //2040 C				#e1075a			
 //2040 U				#e34068			
 //2041 C				#a3234c			
 //2041 U				#a44e63			
 //2042 C				#72273b			
 //2042 U				#7e4e56			
 //2043 C				#e9c3d1			
 //2043 U				#f0c0d1			
 //2044 C				#e993b5			
 //2044 U				#ec93b5			
 //2045 C				#e0739e			
 //2045 U				#e07b9e			
 //2046 C				#d25788			
 //2046 U				#cf6c8d			
 //2047 C				#a7466e			
 //2047 U				#a05f77			
 //2048 C				#983a5f			
 //2048 U				#965a6e			
 //2049 C				#862d4a			
 //2049 U				#8c5463			
 //205				#e54c7c			
 //205 C				#e7417a			
 //205 U				#ea5f83			
 //2050 C				#efd6e4			
 //2050 U				#f7dbe8			
 //2051 C				#ddc0cf			
 //2051 U				#e5c7d4			
 //2052 C				#cb9fb6			
 //2052 U				#cfa5b9			
 //2053 C				#b67e9d			
 //2053 U				#ba8aa3			
 //2054 C				#a06f8c			
 //2054 U				#a47c92			
 //2055 C				#925d7b			
 //2055 U				#997187			
 //2056 C				#814766			
 //2056 U				#8a657a			
 //2057 C				#d291b7			
 //2057 U				#db9fbf			
 //2058 C				#bb85a9			
 //2058 U				#b285a4			
 //2059 C				#ba7aa0			
 //2059 U				#bb83a2			
 //206				#d30547			
 //206 C				#d60036			
 //206 U				#de4164			
 //2060 C				#cb6aa6			
 //2060 U				#cc7aaa			
 //2061 C				#b15188			
 //2061 U				#b66f93			
 //2062 C				#b7448c			
 //2062 U				#b25f8e			
 //2063 C				#a9307b			
 //2063 U				#a3537f			
 //2064 C				#e1a0d2			
 //2064 U				#e394cb			
 //2065 C				#dfa7dc			
 //2065 U				#e1a0da			
 //2066 C				#d38dd2			
 //2066 U				#d68cd1			
 //2067 C				#c269c1			
 //2067 U				#c174bf			
 //2068 C				#b44fb3			
 //2068 U				#b364b2			
 //2069 C				#a738a6			
 //2069 U				#a85aa7			
 //207				#baaa9e			
 //207 C				#ab0032			
 //207 U				#b34b63			
 //2070 C				#911d92			
 //2070 U				#964b95			
 //2071 C				#c7b1dd			
 //2071 U				#ccb3e1			
 //2072 C				#b896d3			
 //2072 U				#ba98d5			
 //2073 C				#b094d2			
 //2073 U				#ad95d3			
 //2074 C				#9669bd			
 //2074 U				#9776bb			
 //2075 C				#8765bb			
 //2075 U				#8c75ba			
 //2076 C				#8558b3			
 //2076 U				#8c6db2			
 //2077 C				#6e3fa0			
 //2077 U				#75579d			
 //2078 C				#b59dbc			
 //2078 U				#bea6c1			
 //2079 C				#9c7da2			
 //2079 U				#a58baa			
 //208				#8e2344			
 //208 C				#8b1c40			
 //208 U				#935466			
 //2080 C				#9872ab			
 //2080 U				#987aa9			
 //2081 C				#875d9c			
 //2081 U				#8d6f9e			
 //2082 C				#7a4d90			
 //2082 U				#836894			
 //2083 C				#965dc7			
 //2083 U				#9c71c8			
 //2084 C				#8037b1			
 //2084 U				#8a5db2			
 //2085 C				#dfcce6			
 //2085 U				#e9d3ec			
 //2086 C				#a08acb			
 //2086 U				#a28fcc			
 //2087 C				#9d7cd3			
 //2087 U				#a085d7			
 //2088 C				#835cc7			
 //2088 U				#866cc5			
 //2089 C				#7148bc			
 //2089 U				#7a61b9			
 //209				#75263d			
 //209 C				#73243c			
 //209 U				#835664			
 //2090 C				#653ab6			
 //2090 U				#755ab2			
 //2091 C				#4b16a0			
 //2091 U				#674da0			
 //2092 C				#b9aad4			
 //2092 U				#b7aad8			
 //2093 C				#a597c1			
 //2093 U				#a697bf			
 //2094 C				#8e7eac			
 //2094 U				#9284ac			
 //2095 C				#7965b2			
 //2095 U				#7f72af			
 //2096 C				#664da1			
 //2096 U				#776aa6			
 //2097 C				#6045b9			
 //2097 U				#6f5eb7			
 //2098 C				#4527a9			
 //2098 U				#6654a8			
 //2099 C				#b1a2ca			
 //2099 U				#aea0c9			
 //210				#ffa0bf			
 //210 C				#fd9fc8			
 //210 U				#ffa2ca			
 //2100 C				#9e8ec9			
 //2100 U				#a495cc			
 //2101 C				#8974d1			
 //2101 U				#8c7cd0			
 //2102 C				#6457b0			
 //2102 U				#726bad			
 //2103 C				#5848a5			
 //2103 U				#6b63a4			
 //2104 C				#483697			
 //2104 U				#655c9b			
 //2105 C				#36217b			
 //2105 U				#615085			
 //2106 C				#b0b4cd			
 //2106 U				#b4b8d2			
 //2107 C				#8f98b9			
 //2107 U				#97a0be			
 //2108 C				#777ea9			
 //2108 U				#7f87a8			
 //2109 C				#696b99			
 //2109 U				#757b9c			
 //211				#ff77a8			
 //211 C				#fb7eb4			
 //211 U				#ff85b4			
 //2110 C				#5a5f8f			
 //2110 U				#6e7494			
 //2111 C				#444c7e			
 //2111 U				#636989			
 //2112 C				#322164			
 //2112 U				#54476e			
 //2113 C				#a4afe3			
 //2113 U				#a7b1e7			
 //2114 C				#838cc9			
 //2114 U				#929cd1			
 //2115 C				#6e78bd			
 //2115 U				#838dc5			
 //2116 C				#5e66b1			
 //2116 U				#7a80ba			
 //2117 C				#44489b			
 //2117 U				#6568a1			
 //2118 C				#323578			
 //2118 U				#595a83			
 //2119 C				#2a2d64			
 //2119 U				#555577			
 //212				#f94f8e			
 //212 C				#f55096			
 //212 U				#f96d9c			
 //2120 C				#bdcaea			
 //2120 U				#b3c3eb			
 //2121 C				#8cabd8			
 //2121 U				#8da9d9			
 //2122 C				#9aade3			
 //2122 U				#8da4e2			
 //2123 C				#7892dd			
 //2123 U				#738bda			
 //2124 C				#6e7bd3			
 //2124 U				#6b77cd			
 //2125 C				#4f62c8			
 //2125 U				#646cc3			
 //2126 C				#273bb2			
 //2126 U				#565baf			
 //2127 C				#b6c8e1			
 //2127 U				#b9cbe4			
 //2128 C				#95b4e4			
 //2128 U				#94b3e6			
 //2129 C				#5a8cda			
 //2129 U				#6a8edb			
 //213				#ea0f6b			
 //213 C				#ea1d75			
 //213 U				#ee5483			
 //2130 C				#5075d0			
 //2130 U				#637ace			
 //2131 C				#2e5bbe			
 //2131 U				#586bba			
 //2132 C				#0056c1			
 //2132 U				#4e6dc3			
 //2133 C				#1356a4			
 //2133 U				#5470a9			
 //2134 C				#90a4cf			
 //2134 U				#9daed6			
 //2135 C				#738bbf			
 //2135 U				#8397c7			
 //2136 C				#8293b8			
 //2136 U				#8493b5			
 //2137 C				#6c7eaa			
 //2137 U				#7784a7			
 //2138 C				#627592			
 //2138 U				#6d798f			
 //2139 C				#4c6896			
 //2139 U				#627496			
 //214				#cc0256			
 //214 C				#d50f67			
 //214 U				#d65079			
 //2140 C				#375182			
 //2140 U				#586689			
 //2141 C				#88bde8			
 //2141 U				#7fb8e9			
 //2142 C				#7bace3			
 //2142 U				#87b1e7			
 //2143 C				#3485cc			
 //2143 U				#5c8ccc			
 //2144 C				#0065ba			
 //2144 U				#4b79bc			
 //2145 C				#004ca7			
 //2145 U				#416bad			
 //2146 C				#00348e			
 //2146 U				#315193			
 //2147 C				#002576			
 //2147 U				#3f4e84			
 //2148 C				#5e8fb3			
 //2148 U				#7094b5			
 //2149 C				#4b80a7			
 //2149 U				#6488a9			
 //215				#a50544			
 //215 C				#af1556			
 //215 U				#b1506f			
 //2150 C				#32739d			
 //2150 U				#5d7e9f			
 //2151 C				#2169a2			
 //2151 U				#52739e			
 //2152 C				#156390			
 //2152 U				#517292			
 //2153 C				#00537d			
 //2153 U				#4e6a87			
 //2154 C				#00447f			
 //2154 U				#435f86			
 //2155 C				#9cb4cb			
 //2155 U				#a2b9d0			
 //2156 C				#8aa4c0			
 //2156 U				#8ea8c4			
 //2157 C				#7192b4			
 //2157 U				#7c95b4			
 //2158 C				#5881a6			
 //2158 U				#6d89a8			
 //2159 C				#4b759b			
 //2159 U				#66809e			
 //216				#7c1e3f			
 //216 C				#802145			
 //216 U				#8b5465			
 //2160 C				#3d6891			
 //2160 U				#5d7694			
 //2161 C				#245681			
 //2161 U				#4f6988			
 //2162 C				#9da4b3			
 //2162 U				#9ca3b2			
 //2163 C				#849aaf			
 //2163 U				#8ea0b2			
 //2164 C				#7c92a7			
 //2164 U				#8396a9			
 //2165 C				#667f98			
 //2165 U				#748699			
 //2166 C				#54718a			
 //2166 U				#6b7d90			
 //2167 C				#4d6b86			
 //2167 U				#647689			
 //2168 C				#22495c			
 //2168 U				#556774			
 //2169 C				#7faed2			
 //2169 U				#80afd3			
 //217				#f4bfd1			
 //217 C				#eebdda			
 //217 U				#f6c0e1			
 //2170 C				#5a9ac6			
 //2170 U				#6094c0			
 //2171 C				#3f9edf			
 //2171 U				#4c95dc			
 //2172 C				#0079d0			
 //2172 U				#5284d3			
 //2173 C				#0083d6			
 //2173 U				#3c81d1			
 //2174 C				#0075cf			
 //2174 U				#3379cb			
 //2175 C				#0068c7			
 //2175 U				#2072c2			
 //2176 C				#a4b7bf			
 //2176 U				#b2c2cb			
 //2177 C				#7d9eab			
 //2177 U				#8da7b3			
 //2178 C				#688d9c			
 //2178 U				#7c97a3			
 //2179 C				#4f7888			
 //2179 U				#6d8896			
 //218				#ed72aa			
 //218 C				#eb6baf			
 //218 U				#f482b8			
 //2180 C				#3c6b7e			
 //2180 U				#607a88			
 //2181 C				#29596b			
 //2181 U				#576f7c			
 //2182 C				#12485b			
 //2182 U				#526975			
 //2183 C				#0090bd			
 //2183 U				#3b91ba			
 //2184 C				#0082d4			
 //2184 U				#2d88d5			
 //2185 C				#0074a6			
 //2185 U				#357ea6			
 //2186 C				#004787			
 //2186 U				#225e8e			
 //2187 C				#004477			
 //2187 U				#375c7e			
 //2188 C				#00406a			
 //2188 U				#3a5b78			
 //2189 C				#003248			
 //2189 U				#435768			
 //219				#e22882			
 //219 C				#e11282			
 //219 U				#e95b95			
 //2190 C				#4fb5e5			
 //2190 U				#4eb1e9			
 //2191 C				#00a1e1			
 //2191 U				#36a2e4			
 //2192 C				#008edb			
 //2192 U				#0095dd			
 //2193 C				#008fdb			
 //2193 U				#148cd9			
 //2194 C				#0083d5			
 //2194 U				#008bd6			
 //2195 C				#0074ce			
 //2195 U				#267dcd			
 //2196 C				#0067b1			
 //2196 U				#0165a0			
 //2197 C				#6ed0e7			
 //2197 U				#63d1ea			
 //2198 C				#3ec7e4			
 //2198 U				#30c7e7			
 //2199 C				#00b8dd			
 //2199 U				#00b8de			
 //220				#aa004f			
 //220 C				#ab004e			
 //220 U				#b44a73			
 //2200 C				#00a6c6			
 //2200 U				#3ea8c7			
 //2201 C				#00abd8			
 //2201 U				#00acd7			
 //2202 C				#00a2e0			
 //2202 U				#00a8e4			
 //2203 C				#0085ae			
 //2203 U				#178bae			
 //2204 C				#adcbd7			
 //2204 U				#aaccd9			
 //2205 C				#88b1c4			
 //2205 U				#86b0c5			
 //2206 C				#769db4			
 //2206 U				#7ea1b7			
 //2207 C				#6198b2			
 //2207 U				#6f9bb3			
 //2208 C				#5287a3			
 //2208 U				#668da3			
 //2209 C				#4684a0			
 //2209 U				#648ca4			
 //221				#930042			
 //221 C				#970047			
 //221 U				#a14c6c			
 //2210 C				#084d71			
 //2210 U				#47637c			
 //2211 C				#6f98a3			
 //2211 U				#7fa2ac			
 //2212 C				#4e8391			
 //2212 U				#688b97			
 //2213 C				#2d6f78			
 //2213 U				#5c7c82			
 //2214 C				#2e6c79			
 //2214 U				#5b7d87			
 //2215 C				#2c5466			
 //2215 U				#516874			
 //2216 C				#2b4b58			
 //2216 U				#4e616a			
 //2217 C				#003841			
 //2217 U				#43565e			
 //2218 C				#6eaebd			
 //2218 U				#75afbf			
 //2219 C				#57a2b3			
 //2219 U				#67a3b4			
 //222				#70193d			
 //222 C				#701c45			
 //222 U				#85556a			
 //2220 C				#4195a9			
 //2220 U				#6199ab			
 //2221 C				#278a9f			
 //2221 U				#548fa0			
 //2222 C				#0a8098			
 //2222 U				#4e879b			
 //2223 C				#00758e			
 //2223 U				#447e92			
 //2224 C				#006681			
 //2224 U				#3c7386			
 //2225 C				#70d3e1			
 //2225 U				#69d6e5			
 //2226 C				#2ec9da			
 //2226 U				#39cbdd			
 //2227 C				#52bcc9			
 //2227 U				#5dbecd			
 //2228 C				#00a2be			
 //2228 U				#00a4be			
 //2229 C				#0099b8			
 //2229 U				#009bb6			
 //223				#f993c4			
 //223 C				#f294cd			
 //223 U				#fca4d6			
 //2230 C				#0089a1			
 //2230 U				#1490a5			
 //2231 C				#007993			
 //2231 U				#008297			
 //2232 C				#6daeb3			
 //2232 U				#75afb5			
 //2233 C				#54a5b0			
 //2233 U				#63a4af			
 //2234 C				#499da5			
 //2234 U				#5c9ba2			
 //2235 C				#1c919d			
 //2235 U				#4e939d			
 //2236 C				#1e909a			
 //2236 U				#4e8e97			
 //2237 U				#4d8990			
 //2238 C				#006776			
 //2238 U				#30737d			
 //2239 C				#00ccb7			
 //2239 U				#00ceb6			
 //224				#f46baf			
 //224 C				#ef6eba			
 //224 U				#f987c6			
 //2240 C				#00bea1			
 //2240 U				#00bfa4			
 //2241 C				#53a092			
 //2241 U				#63a094			
 //2242 C				#00a077			
 //2242 U				#00a081			
 //2243 C				#00927b			
 //2243 U				#3c9383			
 //2244 C				#087e6d			
 //2244 U				#4d857b			
 //2245 C				#008356			
 //2245 U				#008a6c			
 //2246 C				#a7d2b9			
 //2246 U				#a5d6bc			
 //2247 C				#74bf99			
 //2247 U				#7bc4a0			
 //2248 C				#6cb691			
 //2248 U				#78ba98			
 //2249 C				#53a97f			
 //2249 U				#67aa86			
 //225				#ed2893			
 //225 C				#e51992			
 //225 U				#ef60a4			
 //2250 C				#00b073			
 //2250 U				#21ae7b			
 //2251 C				#00aa71			
 //2251 U				#00a778			
 //2252 C				#00a54d			
 //2252 U				#00a763			
 //2253 C				#bae8ca			
 //2253 U				#bfefce			
 //2254 C				#acddb2			
 //2254 U				#ace2b4			
 //2255 C				#85d095			
 //2255 U				#86d59b			
 //2256 C				#53c072			
 //2256 U				#5dc380			
 //2257 C				#00ab51			
 //2257 U				#34aa68			
 //2258 C				#008424			
 //2258 U				#418f53			
 //2259 C				#007022			
 //2259 U				#458151			
 //226				#d60270			
 //226 C				#d7006d			
 //226 U				#e14486			
 //2260 C				#b2cfad			
 //2260 U				#c0dabb			
 //2261 C				#96ba91			
 //2261 U				#93b78e			
 //2262 C				#88ac89			
 //2262 U				#8bac8c			
 //2263 C				#6f946b			
 //2263 U				#7c9a7b			
 //2264 C				#669460			
 //2264 U				#71966f			
 //2265 C				#587d50			
 //2265 U				#738e70			
 //2266 C				#2d5423			
 //2266 U				#577754			
 //2267 C				#96de99			
 //2267 U				#98e69f			
 //2268 C				#72d77d			
 //2268 U				#6edb84			
 //2269 C				#78ca6d			
 //2269 U				#6bc774			
 //227				#ad005b			
 //227 C				#b00060			
 //227 U				#b24776			
 //2270 C				#17c54e			
 //2270 U				#3ac867			
 //2271 C				#00b832			
 //2271 U				#12ba58			
 //2272 C				#00981a			
 //2272 U				#3ba047			
 //2273 C				#227026			
 //2273 U				#4e7c4e			
 //2274 C				#d0d9b1			
 //2274 U				#d6dfb5			
 //2275 C				#c3da95			
 //2275 U				#c7e09a			
 //2276 C				#88a650			
 //2276 U				#8aa667			
 //2277 C				#52941d			
 //2277 U				#649847			
 //2278 C				#4b7f1e			
 //2278 U				#628b4a			
 //2279 C				#5c7d2a			
 //2279 U				#6d8453			
 //228				#8c004c			
 //228 C				#8d0b56			
 //228 U				#8f4d6d			
 //2280 C				#47691d			
 //2280 U				#627a4b			
 //2281 C				#d8e798			
 //2281 U				#dbec99			
 //2282 C				#c6e895			
 //2282 U				#c7ed97			
 //2283 C				#a3df65			
 //2283 U				#a6e474			
 //2284 C				#b0d37d			
 //2284 U				#b0d683			
 //2285 C				#8fd84a			
 //2285 U				#8fdd63			
 //2286 C				#74ca00			
 //2286 U				#7bd145			
 //2287 C				#54c400			
 //2287 U				#5cc647			
 //2288 C				#c8e179			
 //2288 U				#c9e681			
 //2289 C				#c5d779			
 //2289 U				#c6dc84			
 //229				#6d213f			
 //229 C				#692044			
 //229 U				#7b5365			
 //2290 C				#a7d91d			
 //2290 U				#aae053			
 //2291 C				#a4d300			
 //2291 U				#a2d834			
 //2292 C				#91c712			
 //2292 U				#89c648			
 //2293 C				#86c300			
 //2293 U				#8acb23			
 //2294 C				#74a800			
 //2294 U				#7eb03b			
 //2295 C				#e1ea89			
 //2295 U				#e5f08c			
 //2296 C				#d5e664			
 //2296 U				#d6ec70			
 //2297 C				#bcde16			
 //2297 U				#bfe44d			
 //2298 C				#b6d955			
 //2298 U				#afdb66			
 //2299 C				#a2d033			
 //2299 U				#9bd154			
 //230				#ffa0cc			
 //230 C				#f7a6d6			
 //230 U				#ffb2de			
 //2300 C				#a8c140			
 //2300 U				#abc663			
 //2301 C				#8dac14			
 //2301 U				#8fad4d			
 //2302 C				#aeb762			
 //2302 U				#a9b36e			
 //2303 C				#9fb156			
 //2303 U				#9eb16d			
 //2304 C				#a0aa4d			
 //2304 U				#9da763			
 //2305 C				#9da600			
 //2305 U				#9ca647			
 //2306 C				#7e8a24			
 //2306 U				#818c50			
 //2307 C				#676e11			
 //2307 U				#767e40			
 //2308 C				#59561a			
 //2308 U				#6a6941			
 //2309 C				#e7cdb5			
 //2309 U				#eccfb3			
 //231				#fc70ba			
 //231 C				#f677c4			
 //231 U				#fc85c8			
 //2310 C				#d8bfa7			
 //2310 U				#ddc0a7			
 //2311 C				#cca784			
 //2311 U				#cca88a			
 //2312 C				#b79a80			
 //2312 U				#baa08b			
 //2313 C				#c39365			
 //2313 U				#c19676			
 //2314 C				#ac7743			
 //2314 U				#a98062			
 //2315 C				#93480d			
 //2315 U				#96623e			
 //2316 C				#bd9979			
 //2316 U				#c09f85			
 //2317 C				#b4865c			
 //2317 U				#b18c70			
 //2318 C				#a47447			
 //2318 U				#a17d63			
 //2319 C				#8d5b2f			
 //2319 U				#8d6d55			
 //232				#f43fa5			
 //232 C				#ef3fa9			
 //232 U				#f56ab4			
 //2320 C				#714621			
 //2320 U				#795c46			
 //2321 C				#6f5036			
 //2321 U				#7a695b			
 //2322 C				#4d3423			
 //2322 U				#625140			
 //2323 C				#b7b098			
 //2323 U				#c5bfaa			
 //2324 C				#b2a282			
 //2324 U				#ada189			
 //2325 C				#9f9073			
 //2325 U				#a09580			
 //2326 C				#8b7c5e			
 //2326 U				#958b78			
 //2327 C				#837857			
 //2327 U				#908875			
 //2328 C				#786747			
 //2328 U				#807766			
 //2329 C				#69583b			
 //2329 U				#766e61			
 //233				#ce007c			
 //233 C				#cc007a			
 //233 U				#cc4585			
 //2330 C				#cfccc8			
 //2331 C				#aca7a3			
 //2331 U				#b0aba9			
 //2332 C				#8b8985			
 //2332 U				#8b8986			
 //2333 C				#716c69			
 //2333 U				#757473			
 //2334 C				#6d6361			
 //2334 U				#706c6c			
 //2335 C				#5e4e46			
 //2335 U				#706964			
 //2336 C				#4e4946			
 //2336 U				#666565			
 //2337 C				#fac0b8			
 //2337 U				#ffb6ad			
 //2338 C				#e0a39d			
 //2338 U				#dc9b95			
 //2339 C				#f29390			
 //2339 U				#f5908e			
 //234				#aa0066			
 //234 C				#a60063			
 //234 U				#ac4c7b			
 //2340 C				#d26e76			
 //2340 U				#cc797d			
 //2341 C				#b96b6c			
 //2341 U				#ae7475			
 //2342 C				#ba5963			
 //2342 U				#b16c73			
 //2343 C				#aa5564			
 //2343 U				#a86c75			
 //2344 C				#f3806e			
 //2344 U				#f08576			
 //2345 C				#ff6e67			
 //2345 U				#ff7d74			
 //2346 C				#ff5967			
 //2346 U				#ff7075			
 //2347 C				#e80000			
 //2347 U				#ed4336			
 //2348 C				#ea534d			
 //2348 U				#e1615c			
 //2349 C				#ce3402			
 //2349 U				#c44d36			
 //235				#8e0554			
 //235 C				#880d53			
 //235 U				#924e70			
 //2350 C				#b5201b			
 //2350 U				#a1463d			
 //2351 C				#bf79b2			
 //2351 U				#bd81b1			
 //2352 C				#b764a6			
 //2352 U				#b471a3			
 //2353 C				#c44ca5			
 //2353 U				#b85997			
 //2354 C				#944d8a			
 //2354 U				#90638b			
 //2355 C				#8b0079			
 //2355 U				#86467a			
 //2356 C				#750060			
 //2356 U				#7e3f6f			
 //2357 C				#641143			
 //2357 U				#6e435a			
 //2358 C				#ada3ae			
 //2358 U				#a499a5			
 //2359 C				#7e7283			
 //2359 U				#807785			
 //236				#f9afd3			
 //236 C				#f4a7dc			
 //236 U				#faa6dd			
 //2360 C				#7a788e			
 //2360 U				#7f7c8d			
 //2361 C				#6f6f8b			
 //2361 U				#75758c			
 //2362 C				#6d6980			
 //2362 U				#787585			
 //2363 C				#5f5c75			
 //2363 U				#6f6c7c			
 //2364 C				#67586d			
 //2364 U				#726976			
 //2365				#f7c4d8			
 //2365 C				#f2b9df			
 //2365 U				#f9bee6			
 //2366 C				#676ccd			
 //2366 U				#6f71c7			
 //2367 C				#4d4bb0			
 //2367 U				#6663ad			
 //2368 C				#4a49bc			
 //2368 U				#6160b7			
 //2369 C				#3640b5			
 //2369 U				#5b5cb0			
 //237				#f484c4			
 //237 C				#f185ce			
 //237 U				#f58dcf			
 //2370 C				#2b2b93			
 //2370 U				#5d599b			
 //2371 C				#300b8c			
 //2371 U				#58468c			
 //2372 C				#251e77			
 //2372 U				#524d7f			
 //2373 C				#7181a0			
 //2373 U				#78829b			
 //2374 C				#4d5e80			
 //2374 U				#5e687f			
 //2375				#ea6bbf			
 //2375 C				#e677cb			
 //2375 U				#ed88d1			
 //2376 C				#4d5a72			
 //2376 U				#636c7d			
 //2377 C				#305271			
 //2377 U				#55687c			
 //2378 C				#374767			
 //2378 U				#555d71			
 //2379 C				#3b4358			
 //2379 U				#565a66			
 //238				#ed4faf			
 //238 C				#ea5dbd			
 //238 U				#ed72bf			
 //2380 C				#273248			
 //2380 U				#525664			
 //2381 C				#5992db			
 //2381 U				#618dd8			
 //2382 C				#0088d8			
 //2382 U				#3d82d2			
 //2383 C				#2173ad			
 //2383 U				#4a72a2			
 //2384 C				#0060a1			
 //2384 U				#3b6796			
 //2385				#db28a5			
 //2385 C				#d939b2			
 //2385 U				#e56fc0			
 //2386 C				#2768c3			
 //2386 U				#546fbd			
 //2387 C				#0061c8			
 //2387 U				#4767bd			
 //2388 C				#004fb5			
 //2388 U				#3c5ea8			
 //2389 C				#449ec9			
 //2389 U				#5b9cc6			
 //239				#e0219e			
 //239 C				#e03eae			
 //239 U				#e055a7			
 //2390 C				#007bab			
 //2390 U				#4e83aa			
 //2391 C				#0080a5			
 //2391 U				#4683a1			
 //2392 C				#096785			
 //2392 U				#587b90			
 //2393 C				#0090cb			
 //2393 U				#0095cc			
 //2394 C				#0089ce			
 //2394 U				#008fce			
 //2395				#c4008c			
 //2395 C				#cf009e			
 //2395 U				#d956ac			
 //2396 C				#0096b2			
 //2396 U				#0093ab			
 //2397 C				#00b4bd			
 //2397 U				#00b1ba			
 //2398 C				#00b8b3			
 //2398 U				#2cbbb6			
 //2399 C				#00a8a2			
 //2399 U				#00ada8			
 //240				#c40f89			
 //240 C				#cb2b99			
 //240 U				#c55597			
 //2400 C				#00ad97			
 //2400 U				#00ae9a			
 //2401 C				#28a598			
 //2401 U				#52a69b			
 //2402 C				#009a87			
 //2402 U				#009e8d			
 //2403 C				#00867b			
 //2403 U				#008d85			
 //2404 C				#a4b79c			
 //2404 U				#9fb39a			
 //2405				#a8007a			
 //2405 C				#b5008c			
 //2405 U				#be569c			
 //2406 C				#809c87			
 //2406 U				#869f8f			
 //2407 C				#698b72			
 //2407 U				#779080			
 //2408 C				#477956			
 //2408 U				#597865			
 //2409 C				#4b6447			
 //2409 U				#637364			
 //241				#ad0075			
 //241 C				#b41782			
 //241 U				#b15389			
 //2410 C				#415a3d			
 //2410 U				#5f6e5f			
 //2411 C				#1a4020			
 //2411 U				#4a6149			
 //2412 C				#3ad398			
 //2412 U				#5bd8a2			
 //2413 C				#29b58f			
 //2413 U				#47af8e			
 //2414 C				#00b980			
 //2414 U				#24b280			
 //2415				#9b0070			
 //2415 C				#a2007c			
 //2415 U				#ae5490			
 //2416 C				#00ae77			
 //2416 U				#17ae81			
 //2417 C				#189b6b			
 //2417 U				#4e9c79			
 //2418 C				#008440			
 //2418 U				#00845a			
 //2419 C				#007a57			
 //2419 U				#367b68			
 //242				#7c1c51			
 //242 C				#83225e			
 //242 U				#8e5975			
 //2420 C				#00c460			
 //2420 U				#1cc574			
 //2421 C				#1ab500			
 //2421 U				#44b738			
 //2422 C				#00a52e			
 //2422 U				#31a557			
 //2423 C				#00a815			
 //2423 U				#00aa49			
 //2424 C				#1a9d00			
 //2424 U				#46a23a			
 //2425				#87005b			
 //2425 C				#880063			
 //2425 U				#98537f			
 //2426 C				#008918			
 //2426 U				#009247			
 //2427 C				#005d1c			
 //2427 U				#44704a			
 //243				#f2bad8			
 //243 C				#eeb7e2			
 //243 U				#f4b1e4			
 //244				#eda0d3			
 //244 C				#e99bda			
 //244 U				#ee9add			
 //245				#e87fc9			
 //245 C				#e37ed1			
 //245 U				#e47ece			
 //246				#cc00a0			
 //246 C				#cd25af			
 //246 U				#d356b1			
 //247				#b7008e			
 //247 C				#c114a1			
 //247 U				#c150a0			
 //248				#a3057f			
 //248 C				#a9198d			
 //248 U				#a44e8a			
 //249				#7f2860			
 //249 C				#84266a			
 //249 U				#895677			
 //250				#edc4dd			
 //250 C				#eab9e4			
 //250 U				#f0b8e7			
 //251				#e29ed6			
 //251 C				#e19bdf			
 //251 U				#e495dd			
 //252				#d36bc6			
 //252 C				#d162cd			
 //252 U				#d16fcb			
 //253				#af23a5			
 //253 C				#b319ab			
 //253 U				#b856ac			
 //254				#a02d96			
 //254 C				#9e1a96			
 //254 U				#a15499			
 //255				#772d6b			
 //255 C				#77216c			
 //255 U				#83577c			
 //256				#e5c4d6			
 //256 C				#dabddc			
 //256 U				#d5b4da			
 //2562				#d8a8d8			
 //2562 C				#dba8e2			
 //2562 U				#dface8			
 //2563				#d1a0cc			
 //2563 C				#cea2d7			
 //2563 U				#cfa1d9			
 //2567				#bf93cc			
 //2567 C				#c49fd8			
 //2567 U				#c19eda			
 //257				#d3a5c9			
 //257 C				#c9a0ce			
 //257 U				#c499c9			
 //2572				#c687d1			
 //2572 C				#cc8ada			
 //2572 U				#d08fdc			
 //2573				#ba7cbc			
 //2573 C				#bc83c9			
 //2573 U				#ba87ca			
 //2577				#aa72bf			
 //2577 C				#aa7bc9			
 //2577 U				#a47ec5			
 //258				#9b4f96			
 //258 C				#904799			
 //258 U				#a275ad			
 //2582				#aa47ba			
 //2582 C				#b24ec4			
 //2582 U				#bd75ce			
 //2583				#9e4fa5			
 //2583 C				#a35db4			
 //2583 U				#a571b5			
 //2587				#8e47ad			
 //2587 C				#8446ac			
 //2587 U				#936cb5			
 //259				#72166b			
 //259 C				#702076			
 //259 U				#95659b			
 //2592				#930fa5			
 //2592 C				#9f26b4			
 //2592 U				#ad60be			
 //2593				#872b93			
 //2593 C				#873299			
 //2593 U				#8f5e9f			
 //2597				#66008c			
 //2597 C				#5d0c8b			
 //2597 U				#825aa3			
 //260				#681e5b			
 //260 C				#672565			
 //260 U				#8b648c			
 //2602				#820c8e			
 //2602 C				#8b189b			
 //2602 U				#9a57a5			
 //2603				#70147a			
 //2603 C				#732181			
 //2603 U				#86588f			
 //2607				#5b027a			
 //2607 C				#520975			
 //2607 U				#7a5894			
 //261				#5e2154			
 //261 C				#5f285e			
 //261 U				#816181			
 //2612				#701e72			
 //2612 C				#7b2481			
 //2612 U				#88558c			
 //2613				#66116d			
 //2613 C				#6a1e74			
 //2613 U				#7f5685			
 //2617				#560c70			
 //2617 C				#490c66			
 //2617 U				#745387			
 //262				#542344			
 //262 C				#54274e			
 //262 U				#765d73			
 //2622				#602d59			
 //2622 C				#682f64			
 //2622 U				#7d5a79			
 //2623				#5b195e			
 //2623 C				#621f65			
 //2623 U				#76547a			
 //2627				#4c145e			
 //2627 C				#3e1051			
 //2627 U				#6d527a			
 //263				#e0cee0			
 //263 C				#dac4e5			
 //263 U				#dcc4e8			
 //2635				#c9add8			
 //2635 C				#c6b3e1			
 //2635 U				#c8b6e5			
 //264				#c6aadb			
 //264 C				#c4a6e1			
 //264 U				#bfa0e3			
 //2645				#b591d1			
 //2645 C				#b095da			
 //2645 U				#b8a2e2			
 //265				#9663c4			
 //265 C				#9363cc			
 //265 U				#9d7ad2			
 //2655				#9b6dc6			
 //2655 C				#9678d2			
 //2655 U				#a188d7			
 //266				#6d28aa			
 //266 C				#783cbd			
 //266 U				#8a66c2			
 //2665				#894fbf			
 //2665 C				#7f56c5			
 //2665 U				#8b70c8			
 //267				#59118e			
 //267 C				#62259d			
 //267 U				#7f5dac			
 //268				#4f2170			
 //268 C				#5a2b81			
 //268 U				#735990			
 //2685				#56008c			
 //2685 C				#32006e			
 //2685 U				#735ba5			
 //269				#442359			
 //269 C				#532c6c			
 //269 U				#6e577e			
 //2695				#44235e			
 //2695 C				#2f1a45			
 //2695 U				#6b5d7e			
 //270				#baafd3			
 //270 C				#b6b3df			
 //270 U				#adaddd			
 //2705				#ad9ed3			
 //2705 C				#a9a3df			
 //2705 U				#b8b4e8			
 //2706				#d1cedd			
 //2706 C				#ccd2e9			
 //2706 U				#cad3f0			
 //2707				#bfd1e5			
 //2707 C				#c4d5ec			
 //2707 U				#c6daf5			
 //2708				#afbcdb			
 //2708 C				#b9cbea			
 //2708 U				#b2c8ee			
 //271				#9e91c6			
 //271 C				#9794d2			
 //271 U				#9a9ad4			
 //2715				#937acc			
 //2715 C				#8b83d6			
 //2715 U				#9c98df			
 //2716				#a5a0d6			
 //2716 C				#9fade4			
 //2716 U				#a1aee9			
 //2717				#a5bae0			
 //2717 C				#a7c5ed			
 //2717 U				#a7c7f3			
 //2718				#5b77cc			
 //2718 C				#5a87d9			
 //2718 U				#6786d7			
 //272				#8977ba			
 //272 C				#7573c0			
 //272 U				#8585c5			
 //2725				#7251bc			
 //2725 C				#675dc6			
 //2725 U				#8880d2			
 //2726				#6656bc			
 //2726 C				#455cc7			
 //2726 U				#6e7ace			
 //2727				#5e68c4			
 //2727 C				#2e7de1			
 //2727 U				#618ee8			
 //2728				#3044b5			
 //2728 C				#0047ba			
 //2728 U				#4d68c1			
 //273				#38197a			
 //273 C				#23135e			
 //273 U				#645d9a			
 //2735				#4f0093			
 //2735 C				#290088			
 //2735 U				#6658b0			
 //2736				#4930ad			
 //2736 C				#1724a9			
 //2736 U				#5960b9			
 //2738				#2d008e			
 //2738 C				#00098b			
 //2738 U				#424da3			
 //274				#2b1166			
 //274 C				#211650			
 //274 U				#5f578a			
 //2745				#3f0077			
 //2745 C				#250670			
 //2745 U				#5f5499			
 //2746				#3f2893			
 //2746 C				#101e8e			
 //2746 U				#565da3			
 //2747				#1c146b			
 //2747 C				#001a71			
 //2747 U				#3f4f90			
 //2748				#1e1c77			
 //2748 C				#001970			
 //2748 U				#454f8c			
 //275				#260f54			
 //275 C				#211646			
 //275 U				#5c5582			
 //2755				#35006d			
 //2755 C				#221060			
 //2755 U				#5b5389			
 //2756				#332875			
 //2756 C				#121f6b			
 //2756 U				#565b8b			
 //2757				#141654			
 //2757 C				#001e5f			
 //2757 U				#444e7d			
 //2758				#192168			
 //2758 C				#001d60			
 //2758 U				#464d79			
 //276				#2b2147			
 //276 C				#231c34			
 //276 U				#5b546d			
 //2765				#2b0c56			
 //2765 C				#201545			
 //2765 U				#574f76			
 //2766				#2b265b			
 //2766 C				#131b4d			
 //2766 U				#57597b			
 //2767				#14213d			
 //2767 C				#14284b			
 //2767 U				#484b63			
 //2768				#112151			
 //2768 C				#051c48			
 //2768 U				#494c6b			
 //277				#b5d1e8			
 //277 C				#adc8e7			
 //277 U				#accdf1			
 //278				#99badd			
 //278 C				#8cb7e8			
 //278 U				#8bb8ed			
 //279				#6689cc			
 //279 C				#3e8ddd			
 //279 U				#578dda			
 //280				#002b7f			
 //280 C				#012168			
 //280 U				#3a487f			
 //281				#002868			
 //281 C				#001f5b			
 //281 U				#3f4974			
 //282				#002654			
 //282 C				#031d40			
 //282 U				#414765			
 //283				#9bc4e2			
 //283 C				#94c0e9			
 //283 U				#9ac5ed			
 //284				#75aadb			
 //284 C				#6caae4			
 //284 U				#76afe8			
 //285				#3a75c4			
 //285 C				#0070cd			
 //285 U				#4280cf			
 //286				#0038a8			
 //286 C				#0032a0			
 //286 U				#2c54a3			
 //287				#003893			
 //287 C				#002f86			
 //287 U				#395796			
 //288				#00337f			
 //288 C				#002c73			
 //288 U				#3b5486			
 //289				#002649			
 //289 C				#0c223f			
 //289 U				#424e6a			
 //290				#c4d8e2			
 //290 C				#bad8ea			
 //290 U				#a5d2ee			
 //2905				#93c6e0			
 //2905 C				#8fc6e8			
 //2905 U				#88c7ed			
 //291				#a8cee2			
 //291 C				#99caea			
 //291 U				#7cbceb			
 //2915				#60afdd			
 //2915 C				#61b3e4			
 //2915 U				#61b1e8			
 //292				#75b2dd			
 //292 C				#67b2e7			
 //292 U				#5fa7e5			
 //2925				#008ed6			
 //2925 C				#009add			
 //2925 U				#3795da			
 //293				#0051ba			
 //293 C				#003ca6			
 //293 U				#1a59a8			
 //2935				#005bbf			
 //2935 C				#0055b7			
 //2935 U				#0f5ea9			
 //294				#003f87			
 //294 C				#002e6c			
 //294 U				#385888			
 //2945				#0054a0			
 //2945 C				#004a97			
 //2945 U				#26578b			
 //295				#00386b			
 //295 C				#002855			
 //295 U				#344f71			
 //2955				#003d6b			
 //2955 C				#003763			
 //2955 U				#395575			
 //296				#002d47			
 //296 C				#061b2b			
 //296 U				#424e5f			
 //2965				#00334c			
 //2965 C				#00253d			
 //2965 U				#3a5165			
 //297				#82c6e2			
 //297 C				#6ec4e8			
 //297 U				#79caed			
 //2975				#bae0e2			
 //2975 C				#97d4e9			
 //2975 U				#88d4ee			
 //298				#51b5e0			
 //298 C				#40b4e5			
 //298 U				#47b2e8			
 //2985				#51bfe2			
 //2985 C				#57c0e8			
 //2985 U				#41b5e6			
 //299				#00a3dd			
 //299 C				#00a0df			
 //299 U				#0093d9			
 //2995				#00a5db			
 //2995 C				#00a7e1			
 //2995 U				#009adc			
 //300				#0072c6			
 //300 C				#005cb8			
 //300 U				#006cb7			
 //3005				#0084c9			
 //3005 C				#0074c8			
 //3005 U				#0076bf			
 //301				#005b99			
 //301 C				#004987			
 //301 U				#26608d			
 //3015				#00709e			
 //3015 C				#005f9b			
 //3015 U				#176995			
 //302				#004f6d			
 //302 C				#003a5c			
 //302 U				#345c76			
 //3025				#00546b			
 //3025 C				#004d71			
 //3025 U				#345f79			
 //303 C				#012939			
 //303 U				#3e5565			
 //3035				#004454			
 //3035 C				#003d51			
 //3035 U				#3e5665			
 //304				#a5dde2			
 //304 C				#98dae9			
 //304 U				#8adbec			
 //305				#70cee2			
 //305 C				#57c8e7			
 //305 U				#49c8ec			
 //306				#00bce2			
 //306 C				#00b2e2			
 //306 U				#00b2e5			
 //307 C				#0069a6			
 //307 U				#0071a2			
 //308				#00607c			
 //308 C				#00567c			
 //308 U				#206682			
 //309				#003f49			
 //309 C				#003a49			
 //309 U				#3c5763			
 //310				#72d1dd			
 //310 C				#66cfe3			
 //310 U				#55cee6			
 //3105				#7fd6db			
 //3105 C				#62d0df			
 //3105 U				#42ccdf			
 //311				#28c4d8			
 //311 C				#00c1de			
 //311 U				#00bbdc			
 //3115				#2dc6d6			
 //3115 C				#00bfd5			
 //3115 U				#00bcd4			
 //312				#00adc6			
 //312 C				#00a6ce			
 //312 U				#00abd1			
 //3125				#00b7c6			
 //3125 C				#00abc7			
 //3125 U				#00a8c3			
 //313				#0099b5			
 //313 C				#008fbe			
 //313 U				#008ab3			
 //3135				#009baa			
 //3135 C				#008aab			
 //3135 U				#008aa7			
 //314				#00829b			
 //314 C				#007da4			
 //314 U				#007b9b			
 //3145				#00848e			
 //3145 C				#00748c			
 //3145 U				#007588			
 //315				#006b77			
 //315 C				#00657f			
 //315 U				#1c6578			
 //3155				#006d75			
 //3155 C				#005f71			
 //3155 U				#186676			
 //316				#00494f			
 //316 C				#00464f			
 //316 U				#3b5861			
 //3165				#00565b			
 //3165 C				#004d58			
 //3165 U				#2d5a65			
 //317				#c9e8dd			
 //317 C				#b0e2e2			
 //317 U				#abe7e7			
 //318				#93dddb			
 //318 C				#86dade			
 //318 U				#62d7df			
 //319				#4cced1			
 //319 C				#25cad3			
 //319 U				#17c7d1			
 //320				#009ea0			
 //320 C				#0099a8			
 //320 U				#0099a6			
 //321				#008789			
 //321 C				#008995			
 //321 U				#00808b			
 //322				#007272			
 //322 C				#007078			
 //322 U				#0f7179			
 //323				#006663			
 //323 C				#005d62			
 //323 U				#2c5f64			
 //324				#aaddd6			
 //324 C				#9bd9d9			
 //324 U				#7fd6d6			
 //3242				#87ddd1			
 //3242 C				#6edad5			
 //3242 U				#54d9d3			
 //3245				#8ce0d1			
 //3245 C				#7aded4			
 //3245 U				#45d9cc			
 //3248				#7ad3c1			
 //3248 C				#6dcbb8			
 //3248 U				#65ccba			
 //325				#56c9c1			
 //325 C				#64cbc9			
 //325 U				#35bebb			
 //3252				#56d6c9			
 //3252 C				#1bcfc9			
 //3252 U				#00cac3			
 //3255				#47d6c1			
 //3255 C				#22d3c5			
 //3255 U				#00ccbc			
 //3258				#35c4af			
 //3258 C				#48c3b1			
 //3258 U				#43beac			
 //326				#00b2aa			
 //326 C				#00afa9			
 //3262				#00c1b5			
 //3262 C				#00bbb3			
 //3262 U				#00b7b1			
 //3265				#00c6b2			
 //3265 C				#00c4b3			
 //3265 U				#00bcac			
 //3268				#00af99			
 //3268 C				#00a98e			
 //3268 U				#1eaf99			
 //327 C				#008374			
 //3272				#00aa9e			
 //3272 C				#00a19a			
 //3272 U				#00a19c			
 //3275				#00b2a0			
 //3275 C				#00af9a			
 //3275 U				#00a694			
 //3278				#009b84			
 //3278 C				#009877			
 //3278 U				#009982			
 //328				#007770			
 //328 C				#007166			
 //328 U				#077b79			
 //3282				#008c82			
 //3282 C				#00837a			
 //3282 U				#008480			
 //3285				#009987			
 //3285 C				#009382			
 //3285 U				#008d82			
 //3288				#008270			
 //3288 C				#008064			
 //3288 U				#158576			
 //329				#006d66			
 //329 C				#00665e			
 //329 U				#2a7372			
 //3292				#006056			
 //3292 C				#00574f			
 //3292 U				#306c6b			
 //3295				#008272			
 //3295 C				#007564			
 //3295 U				#1c7d74			
 //3298				#006b5b			
 //3298 C				#006852			
 //3298 U				#367267			
 //330				#005951			
 //330 C				#00514b			
 //330 U				#416261			
 //3302				#00493f			
 //3302 C				#004b44			
 //3302 U				#3e5f5e			
 //3305				#004f42			
 //3305 C				#004c42			
 //3305 U				#436863			
 //3308				#004438			
 //3308 C				#034436			
 //3308 U				#465f5a			
 //331				#baead6			
 //331 C				#a6e5d8			
 //331 U				#8fe6d3			
 //332				#a0e5ce			
 //332 C				#89e1d0			
 //332 U				#6adfcb			
 //333				#5eddc1			
 //333 C				#33d9c2			
 //333 U				#00cfb5			
 //334				#00997c			
 //334 C				#009578			
 //334 U				#009380			
 //335				#007c66			
 //335 C				#00795f			
 //335 U				#1a7c70			
 //336				#006854			
 //336 C				#00634f			
 //336 U				#367068			
 //337				#9bdbc1			
 //337 C				#8fd4bc			
 //337 U				#7ed3b9			
 //3375				#8ee2bc			
 //3375 C				#76e0c0			
 //3375 U				#55deb7			
 //338				#7ad1b5			
 //338 C				#6dcdb1			
 //338 U				#45bfa1			
 //3385				#54d8a8			
 //3385 C				#3fd4ad			
 //3385 U				#2fd2a8			
 //339				#00b28c			
 //339 C				#00b188			
 //339 U				#19ab8a			
 //3395				#00c993			
 //3395 C				#00c08a			
 //3395 U				#00c497			
 //340				#009977			
 //340 C				#00945d			
 //340 U				#009b77			
 //3405				#00b27a			
 //3405 C				#00ac68			
 //3405 U				#00ae7b			
 //341				#007a5e			
 //341 C				#007852			
 //341 U				#317663			
 //3415				#007c59			
 //3415 C				#007549			
 //3415 U				#2c7f66			
 //342				#006b54			
 //342 C				#006547			
 //342 U				#3e6d60			
 //3425				#006847			
 //3425 C				#006140			
 //3425 U				#3d7563			
 //343				#00563f			
 //343 C				#0d553f			
 //343 U				#45645b			
 //3435				#024930			
 //3435 C				#144633			
 //3435 U				#49655a			
 //344				#b5e2bf			
 //344 C				#a0d8b3			
 //344 U				#8bd6ad			
 //345				#96d8af			
 //345 C				#91d5ab			
 //345 U				#68cb9b			
 //346				#70ce9b			
 //346 C				#6eca97			
 //346 U				#49bb89			
 //347				#009e60			
 //347 C				#009844			
 //347 U				#089860			
 //348				#008751			
 //348 C				#00833d			
 //348 U				#2f835b			
 //349				#006b3f			
 //349 C				#016836			
 //349 U				#457157			
 //350				#234f33			
 //350 C				#2b5034			
 //350 U				#536557			
 //351				#b5e8bf			
 //351 C				#a2e3b9			
 //351 U				#8fe4b3			
 //352				#99e5b2			
 //352 C				#8ce0b0			
 //352 U				#6adea3			
 //353				#84e2a8			
 //353 C				#7bdea7			
 //353 U				#43d491			
 //354				#00b760			
 //354 C				#00ae41			
 //354 U				#00a75c			
 //355				#009e49			
 //355 C				#00953a			
 //355 U				#00955e			
 //356				#007a3d			
 //356 C				#007833			
 //356 U				#347c59			
 //357				#215b33			
 //357 C				#1c5631			
 //357 U				#4e6e59			
 //358				#aadd96			
 //358 C				#acda90			
 //358 U				#94d68a			
 //359				#a0db8e			
 //359 C				#a2d683			
 //359 U				#79ca77			
 //360				#60c659			
 //360 C				#6cc049			
 //360 U				#58b660			
 //361				#1eb53a			
 //361 C				#3fae29			
 //361 U				#48a84f			
 //362				#339e35			
 //362 C				#4d9c2d			
 //362 U				#53924f			
 //363				#3d8e33			
 //363 C				#4b8b2a			
 //363 U				#56834c			
 //364				#3a7728			
 //364 C				#497527			
 //364 U				#5a784e			
 //365				#d3e8a3			
 //365 C				#c2df87			
 //365 U				#c0e491			
 //366				#c4e58e			
 //366 C				#b7dc78			
 //366 U				#a6da7b			
 //367				#aadd6d			
 //367 C				#a3d55d			
 //367 U				#8dcf68			
 //368				#5bbf21			
 //368 C				#77bc1f			
 //368 U				#65b146			
 //369				#56aa1c			
 //369 C				#62a60a			
 //369 U				#609e44			
 //370				#568e14			
 //370 C				#648b1a			
 //370 U				#688848			
 //371				#566b21			
 //371 C				#546121			
 //371 U				#66714d			
 //372				#d8ed96			
 //372 C				#d4eb8d			
 //372 U				#d0ee8f			
 //373				#ceea82			
 //373 C				#cce97f			
 //373 U				#b6e871			
 //374				#bae860			
 //374 C				#c4e76a			
 //374 U				#a1e15f			
 //375				#8cd600			
 //375 C				#94d500			
 //375 U				#6bc82c			
 //376				#7fba00			
 //376 C				#82bc00			
 //376 U				#6baa36			
 //377				#709302			
 //377 C				#799900			
 //377 U				#6f8d41			
 //378				#566314			
 //378 C				#59611b			
 //378 U				#727a4d			
 //379				#e0ea68			
 //379 C				#e2e665			
 //379 U				#e6ec78			
 //380				#d6e542			
 //380 C				#dbe341			
 //380 U				#d3e257			
 //381				#cce226			
 //381 C				#cedb00			
 //381 U				#b8d537			
 //382				#bad80a			
 //382 C				#c3d500			
 //382 U				#98c11e			
 //383				#a3af07			
 //383 C				#aaad00			
 //383 U				#8d9935			
 //384				#939905			
 //384 C				#959300			
 //384 U				#878a3b			
 //385				#707014			
 //385 C				#79701f			
 //385 U				#7c794a			
 //386				#e8ed60			
 //386 C				#eceb6b			
 //386 U				#eef076			
 //387				#e0ed44			
 //387 C				#e3e733			
 //387 U				#e1ec52			
 //388				#d6e80f			
 //388 C				#e1e61e			
 //388 U				#d3e636			
 //389				#cee007			
 //389 C				#cede00			
 //389 U				#b9db00			
 //390				#bac405			
 //390 C				#b6bd00			
 //390 U				#94a824			
 //391				#9e9e07			
 //391 C				#9a9400			
 //391 U				#878a39			
 //392				#848205			
 //392 C				#837902			
 //392 U				#7f7c40			
 //393				#f2ef87			
 //393 C				#f1ec72			
 //393 U				#f7f182			
 //3935				#f2ed6d			
 //3935 C				#f5e85b			
 //3935 U				#fdf287			
 //394				#eaed35			
 //394 C				#eee838			
 //394 U				#f1ed55			
 //3945				#efea07			
 //3945 C				#f5e500			
 //3945 U				#fdef5c			
 //395				#e5e811			
 //395 C				#ece813			
 //395 U				#ebea3c			
 //3955				#ede211			
 //3955 C				#f2df00			
 //3955 U				#faea33			
 //396				#e0e20c			
 //396 C				#e1e000			
 //396 U				#d8e200			
 //3965				#e8dd11			
 //3965 C				#eedc00			
 //3965 U				#f8e709			
 //397				#c1bf0a			
 //397 C				#c0b800			
 //397 U				#a7a92e			
 //3975				#b5a80c			
 //3975 C				#bea600			
 //3975 U				#b7a62c			
 //398				#afa80a			
 //398 C				#ada300			
 //398 U				#969437			
 //3985				#998c0a			
 //3985 C				#9a8600			
 //3985 U				#9c8f3f			
 //399				#998e07			
 //399 C				#a29100			
 //399 U				#8a8537			
 //3995				#6d6002			
 //3995 C				#6a5c1f			
 //3995 U				#827a4a			
 //400				#d1c6b5			
 //400 C				#c6beb5			
 //400 U				#c7c0b9			
 //401				#c1b5a5			
 //401 C				#b1a99e			
 //401 U				#b4ada6			
 //402				#afa593			
 //402 C				#9e948b			
 //402 U				#a29c97			
 //403				#998c7c			
 //403 C				#8d837a			
 //403 U				#928c87			
 //404				#827566			
 //404 C				#776d63			
 //404 U				#8b8580			
 //405				#6b5e4f			
 //405 C				#696057			
 //405 U				#77716c			
 //406				#cec1b5			
 //406 C				#c7bbb5			
 //406 U				#c6beb9			
 //407 C				#b2a7a1			
 //407 U				#aba09e			
 //408				#a8998c			
 //408 C				#998b86			
 //408 U				#9d9494			
 //409				#99897c			
 //409 C				#877873			
 //409 U				#948a88			
 //410				#7c6d63			
 //410 C				#756660			
 //410 U				#8a817f			
 //411				#66594c			
 //411 C				#60504c			
 //411 U				#7a716f			
 //412				#3d3028			
 //412 C				#392e2c			
 //412 U				#645b59			
 //413				#c6c1b2			
 //413 C				#bbb9af			
 //413 U				#bbbcb3			
 //414				#b5afa0			
 //414 C				#aaa89e			
 //414 U				#a9aba4			
 //415				#a39e8c			
 //415 C				#929287			
 //415 U				#9c9e99			
 //416				#8e8c7a			
 //416 C				#7f7e73			
 //416 U				#8f918c			
 //417				#777263			
 //417 C				#66665c			
 //417 U				#81837d			
 //418				#605e4f			
 //418 C				#525249			
 //418 U				#787a75			
 //419				#282821			
 //419 C				#212221			
 //419 U				#585753			
 //420				#d1ccbf			
 //420 C				#c9c8c7			
 //420 U				#bdbdbc			
 //421				#bfbaaf			
 //421 C				#b2b3b2			
 //421 U				#b2b4b4			
 //422				#afaaa3			
 //422 C				#9fa1a1			
 //422 U				#9ea0a2			
 //423				#96938e			
 //423 C				#8a8b8c			
 //423 U				#909295			
 //424				#827f77			
 //424 C				#707170			
 //424 U				#878889			
 //425				#60605b			
 //425 C				#545759			
 //425 U				#7a7c7e			
 //426				#2b2b28			
 //426 C				#252729			
 //426 U				#686768			
 //427				#dddbd1			
 //427 C				#d0d2d3			
 //427 U				#c2c7c9			
 //428				#d1cec6			
 //428 C				#c3c5c8			
 //428 U				#acb2b8			
 //429				#adafaa			
 //429 C				#a3a9ac			
 //429 U				#90979e			
 //430				#919693			
 //430 C				#7c858c			
 //430 U				#7e888f			
 //431				#666d70			
 //431 C				#5c666f			
 //431 U				#737a82			
 //432				#444f51			
 //432 C				#333d47			
 //432 U				#656b72			
 //433				#30383a			
 //433 C				#1e242b			
 //433 U				#5b5c62			
 //434				#e0d1c6			
 //434 C				#d0c4c4			
 //434 U				#d3c9c9			
 //435				#d3bfb7			
 //435 C				#c0b2b5			
 //435 U				#b3a8ac			
 //436				#bca59e			
 //436 C				#aa989c			
 //436 U				#a89a9d			
 //437				#8c706b			
 //437 C				#7b6568			
 //437 U				#8c7f81			
 //438				#593f3d			
 //438 C				#584444			
 //438 U				#7f7273			
 //439				#493533			
 //439 C				#443634			
 //439 U				#726767			
 //440				#3f302b			
 //440 C				#382d2b			
 //440 U				#67605e			
 //441				#d1d1c6			
 //441 C				#bdc6c3			
 //441 U				#b6c2c0			
 //442				#babfb7			
 //442 C				#a0acaa			
 //442 U				#a9b5b5			
 //443				#a3a8a3			
 //443 C				#909c9c			
 //443 U				#8c999a			
 //444				#898e8c			
 //444 C				#707b7b			
 //444 U				#7c8688			
 //445				#565959			
 //445 C				#4e5758			
 //445 U				#687171			
 //446				#494c49			
 //446 C				#3d4542			
 //446 U				#626867			
 //447				#3f3f38			
 //447 C				#373935			
 //447 U				#5d605f			
 //448				#54472d			
 //448 C				#4c4028			
 //448 U				#67604e			
 //4485				#604c11			
 //4485 C				#634e25			
 //4485 U				#7b6e4b			
 //449				#544726			
 //449 C				#554525			
 //449 U				#706a52			
 //4495				#877530			
 //4495 C				#8e7630			
 //4495 U				#91825e			
 //450				#60542b			
 //450 C				#5c4925			
 //450 U				#807659			
 //4505				#a09151			
 //4505 C				#9b8442			
 //4505 U				#a39671			
 //451				#ada07a			
 //451 C				#9f915d			
 //451 U				#939072			
 //4515				#bcad75			
 //4515 C				#b5a268			
 //4515 U				#b1a47e			
 //452				#c4b796			
 //452 C				#b3a77d			
 //452 U				#a8a586			
 //4525				#ccbf8e			
 //4525 C				#c7b683			
 //4525 U				#c1b38b			
 //453				#d6ccaf			
 //453 C				#c3ba98			
 //453 U				#bdb798			
 //4535				#dbcea5			
 //4535 C				#d1c392			
 //4535 U				#cbbd94			
 //454				#e2d8bf			
 //454 C				#cdc4a6			
 //454 U				#cbc6ab			
 //4545				#e5dbba			
 //4545 C				#d6ca9e			
 //4545 U				#d6cba5			
 //455				#665614			
 //455 C				#6c5a23			
 //455 U				#776e48			
 //456				#998714			
 //456 C				#a58d28			
 //456 U				#918144			
 //457				#b59b0c			
 //457 C				#ba9c13			
 //457 U				#ad9641			
 //458				#ddcc6b			
 //458 C				#dbc554			
 //458 U				#cfb863			
 //459				#e2d67c			
 //459 C				#e0cc61			
 //459 U				#dfca76			
 //460				#eadd96			
 //460 C				#e7d67e			
 //460 U				#e9d789			
 //461				#ede5ad			
 //461 C				#ecde97			
 //461 U				#eee09d			
 //462				#5b4723			
 //462 C				#5e452a			
 //462 U				#70614c			
 //4625				#472311			
 //4625 C				#512b1c			
 //4625 U				#715744			
 //463				#755426			
 //463 C				#774d27			
 //463 U				#876d51			
 //4635				#8c5933			
 //4635 C				#975f35			
 //4635 U				#92705c			
 //464				#876028			
 //464 C				#8f5927			
 //464 U				#9e7b56			
 //4645				#b28260			
 //4645 C				#b07c57			
 //4645 U				#a17d6b			
 //465				#c1a875			
 //465 C				#bd955a			
 //465 U				#b2926f			
 //4655				#c49977			
 //4655 C				#c19372			
 //4655 U				#b28d7a			
 //466				#d1bf91			
 //466 C				#caa976			
 //466 U				#c4a480			
 //4665				#d8b596			
 //4665 C				#cea787			
 //4665 U				#caa48b			
 //467				#ddcca5			
 //467 C				#d6ba8b			
 //467 U				#d5b892			
 //4675				#e5c6aa			
 //4675 C				#debfa4			
 //4675 U				#dcb89f			
 //468				#e2d6b5			
 //468 C				#dfc9a2			
 //468 U				#e1cda9			
 //4685				#edd3bc			
 //4685 C				#e1c5ac			
 //4685 U				#e6cab3			
 //469				#603311			
 //469 C				#6b3f22			
 //469 U				#7b5f4a			
 //4695				#51261c			
 //4695 C				#5d3326			
 //4695 U				#775b4f			
 //470				#9b4f19			
 //470 C				#a75928			
 //470 U				#a56f51			
 //4705				#7c513d			
 //4705 C				#814c3a			
 //4705 U				#8b6e65			
 //471				#bc5e1e			
 //471 C				#bc6123			
 //471 U				#c17a52			
 //4715				#99705b			
 //4715 C				#996a57			
 //4715 U				#9b7c73			
 //472				#eaaa7a			
 //472 C				#e79d6c			
 //472 U				#dd926f			
 //4725				#b5917c			
 //4725 C				#b28877			
 //4725 U				#b09087			
 //473				#f4c4a0			
 //473 C				#f5be99			
 //473 U				#efab87			
 //4735				#ccaf9b			
 //4735 C				#c3a291			
 //4735 U				#bfa094			
 //474				#f4ccaa			
 //474 C				#f4c6a6			
 //474 U				#f7bd9b			
 //4745				#d8bfaa			
 //4745 C				#cfb4a7			
 //4745 U				#d0b3a8			
 //475				#f7d3b5			
 //475 C				#f4cfb2			
 //475 U				#fbcbab			
 //4755				#e2ccba			
 //4755 C				#dac2b6			
 //4755 U				#ddc5bb			
 //476				#593d2b			
 //476 C				#513528			
 //476 U				#6d5c50			
 //477				#633826			
 //477 C				#663a2a			
 //477 U				#7e6355			
 //478				#7a3f28			
 //478 C				#753d29			
 //478 U				#906d5b			
 //479				#af8970			
 //479 C				#ae7f65			
 //479 U				#ae8a7d			
 //480				#d3b7a3			
 //480 C				#c9a791			
 //480 U				#c5a292			
 //481				#e0ccba			
 //481 C				#d6b9a7			
 //481 U				#d6b5a6			
 //482				#e5d3c1			
 //482 C				#dec7b6			
 //482 U				#e0c6b6			
 //483				#6b3021			
 //483 C				#682f24			
 //483 U				#805a4e			
 //484				#9b301c			
 //484 C				#9f3122			
 //484 U				#a35a4d			
 //485				#d81e05			
 //485 C				#e2231a			
 //485 U				#ea5b4e			
 //486				#ed9e84			
 //486 C				#ef8f7a			
 //486 U				#f48a7f			
 //487				#efb5a0			
 //487 C				#f0a693			
 //487 U				#f7a192			
 //488				#f2c4af			
 //488 C				#f1b8a8			
 //488 U				#f7b7a7			
 //489				#f2d1bf			
 //489 C				#f0c2b2			
 //489 U				#f8c6b7			
 //490				#5b2626			
 //490 C				#5e292a			
 //490 U				#775552			
 //491				#752828			
 //491 C				#813033			
 //491 U				#8f5958			
 //492				#913338			
 //492 C				#933235			
 //492 U				#9d5e5e			
 //493 C				#de8797			
 //493 U				#c97c86			
 //494				#f2adb2			
 //494 C				#eca2b0			
 //494 U				#e59ba7			
 //495				#f4bcbf			
 //495 C				#f4bdc6			
 //495 U				#f3afba			
 //496				#f7c9c6			
 //496 C				#f4c6ce			
 //496 U				#fac2cb			
 //497				#512826			
 //497 C				#52302c			
 //497 U				#705854			
 //4975				#441e1c			
 //4975 C				#411f1f			
 //4975 U				#735553			
 //498				#6d332b			
 //498 C				#6a3833			
 //498 U				#805c5a			
 //4985				#844949			
 //4985 C				#894b51			
 //4985 U				#8f6a6d			
 //499				#7a382d			
 //499 C				#7a3f38			
 //499 U				#8c615d			
 //4995				#a56b6d			
 //4995 C				#9d6167			
 //4995 U				#a0787e			
 //500				#ce898c			
 //500 C				#c8868c			
 //500 U				#bd8a8e			
 //5005				#bc8787			
 //5005 C				#b27b80			
 //5005 U				#b28a8f			
 //501				#eab2b2			
 //501 C				#dca5ab			
 //501 U				#d8a5a9			
 //5015				#d8ada8			
 //5015 C				#cda1a5			
 //5015 U				#cba0a4			
 //502				#f2c6c4			
 //502 C				#e6bbc0			
 //502 U				#e5b7bb			
 //5025				#e2bcb7			
 //5025 C				#ddb7bb			
 //5025 U				#dcb6ba			
 //503				#f4d1cc			
 //503 C				#ebc4c6			
 //503 U				#f1cccd			
 //5035				#edcec6			
 //5035 C				#e1c2c1			
 //5035 U				#e6c6c6			
 //504				#511e26			
 //504 C				#572930			
 //504 U				#7f5c60			
 //505				#661e2b			
 //505 C				#702d3d			
 //505 U				#8b5c64			
 //506				#7a2638			
 //506 C				#87354c			
 //506 U				#9b6370			
 //507				#d8899b			
 //507 C				#d891a8			
 //507 U				#cf8ea1			
 //508				#e8a5af			
 //508 C				#e6a9b8			
 //508 U				#e09cac			
 //509				#f2babf			
 //509 C				#ebb3c3			
 //509 U				#ebaebd			
 //510				#f4c6c9			
 //510 C				#edbec8			
 //510 U				#f3bfcb			
 //511				#602144			
 //511 C				#632c4f			
 //511 U				#735567			
 //5115				#4f213a			
 //5115 C				#532943			
 //5115 U				#6f5462			
 //512				#84216b			
 //512 C				#853175			
 //512 U				#8a587e			
 //5125				#754760			
 //5125 C				#6d3a5d			
 //5125 U				#7e6276			
 //513				#9e2387			
 //513 C				#94348c			
 //513 U				#9e5f97			
 //5135				#936b7f			
 //5135 C				#815374			
 //5135 U				#8d7086			
 //514				#d884bc			
 //514 C				#d68bc6			
 //514 U				#d08ac1			
 //5145				#ad8799			
 //5145 C				#9e7691			
 //5145 U				#a5879e			
 //515				#e8a3c9			
 //515 C				#e4acd5			
 //515 U				#e2a5d4			
 //5155				#ccafb7			
 //5155 C				#c1a4b7			
 //5155 U				#b99db1			
 //516				#f2bad3			
 //516 C				#e9bedb			
 //516 U				#e8b6d9			
 //5165				#e0c9cc			
 //5165 C				#d4bfcc			
 //5165 U				#cdb3c3			
 //517				#f4ccd8			
 //517 C				#edc5de			
 //517 U				#f3c8e1			
 //5175				#e8d6d1			
 //5175 C				#dac6ce			
 //5175 U				#dbc4cf			
 //518				#512d44			
 //518 C				#4d2e47			
 //518 U				#6d5968			
 //5185				#472835			
 //5185 C				#4c3040			
 //5185 U				#746068			
 //519				#63305e			
 //519 C				#5b305d			
 //519 U				#785d7b			
 //5195				#593344			
 //5195 C				#684458			
 //5195 U				#816b77			
 //520				#703572			
 //520 C				#662e6b			
 //520 U				#825e86			
 //5205				#8e6877			
 //5205 C				#886378			
 //5205 U				#907b89			
 //521				#b58cb2			
 //521 C				#a87eb1			
 //521 U				#aa89b4			
 //5215				#b5939b			
 //5215 C				#b095a5			
 //5215 U				#a28c9a			
 //522				#c6a3c1			
 //522 C				#bd9bc4			
 //522 U				#be9dc5			
 //5225				#ccadaf			
 //5225 C				#c8afbb			
 //5225 U				#c3abb8			
 //523				#d3b7cc			
 //523 C				#ccb0cf			
 //523 U				#d2b5d4			
 //5235				#ddc6c4			
 //5235 C				#d2bdc6			
 //5235 U				#d6c2ca			
 //524				#e2ccd3			
 //524 C				#d7c2d6			
 //524 U				#dcc4dc			
 //5245				#e5d3cc			
 //5245 C				#ddcdd2			
 //5245 U				#dfcfd4			
 //525				#512654			
 //525 C				#592b5e			
 //525 U				#735675			
 //5255				#35264f			
 //5255 C				#1e1933			
 //5255 U				#5d566c			
 //526				#68217a			
 //526 C				#742f8a			
 //526 U				#815790			
 //5265				#493d63			
 //5265 C				#40395f			
 //5265 U				#6e6a81			
 //527				#7a1e99			
 //527 C				#8430a6			
 //527 U				#945fae			
 //5275				#605677			
 //5275 C				#5a5377			
 //5275 U				#797891			
 //528				#af72c1			
 //528 C				#ba80d0			
 //528 U				#ba88d2			
 //5285				#8c8299			
 //5285 C				#8e88a3			
 //5285 U				#9593ab			
 //529				#cea3d3			
 //529 C				#cea1dc			
 //529 U				#cfa3e0			
 //5295				#b2a8b5			
 //5295 C				#b4afc3			
 //5295 U				#b1adc3			
 //530				#d6afd6			
 //530 C				#dab7e2			
 //530 U				#dcb8e7			
 //5305				#ccc1c6			
 //5305 C				#c7c3d1			
 //5305 U				#c4c1d1			
 //531				#e5c6db			
 //531 C				#e2c7e6			
 //531 U				#e4c6ea			
 //5315				#dbd3d3			
 //5315 C				#dad6de			
 //5315 U				#dad7e1			
 //532				#353842			
 //532 C				#1c1e29			
 //532 U				#5b5a62			
 //533				#353f5b			
 //533 C				#212844			
 //533 U				#5e6378			
 //534				#3a4972			
 //534 C				#1e345d			
 //534 U				#5a6783			
 //535				#9ba3b7			
 //535 C				#8e9ebc			
 //535 U				#8b9cb8			
 //536				#adb2c1			
 //536 C				#a2b1c8			
 //536 U				#a2b4ca			
 //537				#c4c6ce			
 //537 C				#bbc6d6			
 //537 U				#bbc9d9			
 //538				#d6d3d6			
 //538 C				#c6cfda			
 //538 U				#ccd5e0			
 //539				#003049			
 //539 C				#002539			
 //539 U				#455063			
 //5395				#02283a			
 //5395 C				#0a1e2c			
 //5395 U				#464a58			
 //540				#00335b			
 //540 C				#002f56			
 //540 U				#3f506e			
 //5405				#3f6075			
 //5405 C				#4f738a			
 //5405 U				#596e80			
 //541				#003f77			
 //541 C				#003b70			
 //541 U				#38547a			
 //5415				#607c8c			
 //5415 C				#5d7e95			
 //5415 U				#657d91			
 //542				#6693bc			
 //542 C				#7cadd3			
 //542 U				#679ac6			
 //5425				#8499a5			
 //5425 C				#7c97ab			
 //5425 U				#7891a4			
 //543				#93b7d1			
 //543 C				#a4c7e2			
 //543 U				#78a9d2			
 //5435				#afbcbf			
 //5435 C				#a7bac8			
 //5435 U				#9cb3c4			
 //544				#b7ccdb			
 //544 C				#bfd4e6			
 //544 U				#96bfde			
 //5445				#c4cccc			
 //5445 C				#b8c7d3			
 //5445 U				#b3c6d2			
 //545				#c4d3dd			
 //545 C				#c7d9e6			
 //545 U				#accde5			
 //5455				#d6d8d3			
 //5455 C				#bfcdd4			
 //5455 U				#c7d5df			
 //546				#0c3844			
 //546 C				#08292f			
 //546 U				#444e57			
 //5463				#00353a			
 //5463 C				#08262c			
 //5463 U				#3d4d56			
 //5467				#193833			
 //5467 C				#1a322e			
 //5467 U				#535e5e			
 //547				#003f54			
 //547 C				#002f3b			
 //547 U				#415766			
 //5473				#26686d			
 //5473 C				#095c66			
 //5473 U				#4f6c75			
 //5477				#3a564f			
 //5477 C				#3f5b57			
 //5477 U				#5e6f6f			
 //548				#004459			
 //548 C				#003b4c			
 //548 U				#3e5c6f			
 //5483				#609191			
 //5483 C				#4d858d			
 //5483 U				#5c8088			
 //5487				#667c72			
 //5487 C				#5f7774			
 //5487 U				#687b7d			
 //549				#5e99aa			
 //549 C				#6aa2b8			
 //549 U				#6797ad			
 //5493				#8cafad			
 //5493 C				#7ea7ac			
 //5493 U				#739aa2			
 //5497				#91a399			
 //5497 C				#849794			
 //5497 U				#819393			
 //550				#87afbf			
 //550 C				#8db7c9			
 //550 U				#78a8be			
 //5503				#aac4bf			
 //5503 C				#93b6bb			
 //5503 U				#91b5bb			
 //5507				#afbab2			
 //5507 C				#9daeab			
 //5507 U				#96a7a6			
 //551				#a3c1c9			
 //551 C				#a4c5d2			
 //551 U				#95becd			
 //5513				#ced8d1			
 //5513 C				#acc6c8			
 //5513 U				#abc8cc			
 //5517				#c9cec4			
 //5517 C				#b2bfbb			
 //5517 U				#a7b8b7			
 //552				#c4d6d6			
 //552 C				#bbd2db			
 //552 U				#aecddb			
 //5523				#d6ddd6			
 //5523 C				#b7cecf			
 //5523 U				#bbd4d5			
 //5527				#ced1c6			
 //5527 C				#bcc7c4			
 //5527 U				#b7c6c3			
 //553				#234435			
 //553 C				#2a4633			
 //553 U				#59675c			
 //5535				#213d30			
 //5535 C				#172f28			
 //5535 U				#475855			
 //554				#195e47			
 //554 C				#225a40			
 //554 U				#567465			
 //5545				#4f6d5e			
 //5545 C				#43685a			
 //5545 U				#5f756f			
 //555				#076d54			
 //555 C				#2c704f			
 //555 U				#557c6a			
 //5555				#779182			
 //5555 C				#5b7f70			
 //5555 U				#738c86			
 //556				#7aa891			
 //556 C				#70a087			
 //556 U				#719b8b			
 //5565				#96aa99			
 //5565 C				#7e9c90			
 //5565 U				#87a19a			
 //557				#a3c1ad			
 //557 C				#87af99			
 //557 U				#88b09e			
 //5575				#afbfad			
 //5575 C				#92aba0			
 //5575 U				#9bb3aa			
 //558				#b7cebc			
 //558 C				#9bbdaa			
 //558 U				#99bead			
 //5585				#c4cebf			
 //5585 C				#a6bcb0			
 //5585 U				#a1b8af			
 //559				#c6d6c4			
 //559 C				#afc9b8			
 //559 U				#b5d0c0			
 //5595				#d8dbcc			
 //5595 C				#becdc2			
 //5595 U				#bfd1c7			
 //560				#2b4c3f			
 //560 C				#1b3c33			
 //560 U				#495d5b			
 //5605				#233a2d			
 //5605 C				#22362a			
 //5605 U				#5e685e			
 //561				#266659			
 //561 C				#00584d			
 //561 U				#446c68			
 //5615				#546856			
 //5615 C				#5e7260			
 //5615 U				#6a776f			
 //562				#1e7a6d			
 //562 C				#006e62			
 //562 U				#3e7f7b			
 //5625				#728470			
 //5625 C				#728472			
 //5625 U				#79877f			
 //563				#7fbcaa			
 //563 C				#67baaf			
 //563 U				#71b8b0			
 //5635				#9eaa99			
 //5635 C				#95a495			
 //5635 U				#8d9c94			
 //564				#05705e			
 //564 C				#82c7bc			
 //564 U				#82c5bb			
 //5645				#bcc1b2			
 //5645 C				#a4b1a3			
 //5645 U				#9faea5			
 //565				#bcdbcc			
 //565 C				#9fd4c9			
 //565 U				#8dd0c4			
 //5655				#c6ccba			
 //5655 C				#b2bcaf			
 //5655 U				#b3beb4			
 //566				#d1e2d3			
 //566 C				#b7dbd1			
 //566 U				#b0e0d6			
 //5665				#d6d6c6			
 //5665 C				#bcc4b9			
 //5665 U				#bac6bc			
 //567				#265142			
 //567 C				#163d34			
 //567 U				#49625d			
 //568 C				#006a5a			
 //568 U				#427f76			
 //569				#008772			
 //569 C				#007f6d			
 //569 U				#238d81			
 //570				#7fc6b2			
 //570 C				#69c9b9			
 //570 U				#5bc1b3			
 //571				#aadbc6			
 //571 C				#94dace			
 //571 U				#80d6c7			
 //572				#bce2ce			
 //572 C				#a2ded2			
 //572 U				#90dccf			
 //573				#cce5d6			
 //573 C				#b4e1d8			
 //573 U				#b8e8de			
 //574				#495928			
 //574 C				#4e5a30			
 //574 U				#697155			
 //5743				#3f4926			
 //5743 C				#404726			
 //5743 U				#636951			
 //5747				#424716			
 //5747 C				#3e431c			
 //5747 U				#6f734d			
 //575				#547730			
 //575 C				#69813a			
 //575 U				#6f8256			
 //5753				#5e663a			
 //5753 C				#606637			
 //5753 U				#747b60			
 //5757				#6b702b			
 //5757 C				#6c702d			
 //5757 U				#80845b			
 //576				#608e3a			
 //576 C				#7a9b49			
 //576 U				#7b9961			
 //5763				#777c4f			
 //5763 C				#767a4c			
 //5763 U				#7d856c			
 //5767				#8c914f			
 //5767 C				#8c8c48			
 //5767 U				#93966b			
 //577				#b5cc8e			
 //577 C				#abc27e			
 //577 U				#93b279			
 //5773				#9b9e72			
 //5773 C				#8a8f64			
 //5773 U				#98a084			
 //5777				#aaad75			
 //5777 C				#a2a467			
 //5777 U				#a5a87a			
 //578				#c6d6a0			
 //578 C				#b8cd95			
 //578 U				#a7c28d			
 //5783				#b5b58e			
 //5783 C				#a4a982			
 //5783 U				#b4b99e			
 //5787				#c6c699			
 //5787 C				#babc89			
 //5787 U				#babd90			
 //579				#c9d6a3			
 //579 C				#bfcf9a			
 //579 U				#b9cf9d			
 //5793				#c6c6a5			
 //5793 C				#b4b794			
 //5793 U				#c5c8ae			
 //5797				#d3d1aa			
 //5797 C				#c7c79a			
 //5797 U				#c6c99b			
 //580				#d8ddb5			
 //580 C				#c5d4a3			
 //580 U				#cadaac			
 //5803				#d8d6b7			
 //5803 C				#c4c6a6			
 //5803 U				#d0d1b8			
 //5807				#e0ddbc			
 //5807 C				#d1d0a9			
 //5807 U				#d1d2a9			
 //581				#605e11			
 //581 C				#645c20			
 //581 U				#787449			
 //5815				#494411			
 //5815 C				#564f23			
 //5815 U				#726e4a			
 //582				#878905			
 //582 C				#918c10			
 //582 U				#919044			
 //5825				#75702b			
 //5825 C				#8b803a			
 //5825 U				#8a855c			
 //583				#aaba0a			
 //583 C				#b9be10			
 //583 U				#a5b13e			
 //5835				#9e9959			
 //5835 C				#a19856			
 //5835 U				#948e65			
 //584				#ced649			
 //584 C				#d5d654			
 //584 U				#ced564			
 //5845				#b2aa70			
 //5845 C				#b1a96e			
 //5845 U				#a7a274			
 //585				#dbe06b			
 //585 C				#dedd6e			
 //585 U				#e3e584			
 //5855				#ccc693			
 //5855 C				#c1ba85			
 //5855 U				#bcb788			
 //586				#e2e584			
 //586 C				#e3e17b			
 //586 U				#e6e786			
 //5865				#d6cea3			
 //5865 U				#cec794			
 //587				#e8e89b			
 //587 C				#e5e38c			
 //587 U				#eceb97			
 //5875				#e0dbb5			
 //5875 C				#d5cd9e			
 //5875 U				#d7d19f			
 //600				#f4edaf			
 //600 C				#f2ea9a			
 //600 U				#faf19b			
 //601				#f2ed9e			
 //601 C				#f2e88e			
 //601 U				#f7ee8d			
 //602				#f2ea87			
 //602 C				#f2e77a			
 //602 U				#f7ec81			
 //603				#ede85b			
 //603 C				#efe048			
 //603 U				#f4e461			
 //604				#e8dd21			
 //604 C				#edda22			
 //604 U				#eeda4c			
 //605				#ddce11			
 //605 C				#e2cc00			
 //605 U				#e1cb38			
 //606				#d3bf11			
 //606 C				#d1b400			
 //606 U				#cfb724			
 //607				#f2eabc			
 //607 C				#ede499			
 //607 U				#f3e9a1			
 //608				#efe8ad			
 //608 C				#eae085			
 //608 U				#f0e590			
 //609				#eae596			
 //609 C				#e9dc75			
 //609 U				#ebde80			
 //610				#e2db72			
 //610 C				#e2d354			
 //610 U				#dfd166			
 //611				#d6ce49			
 //611 C				#d8c722			
 //611 U				#c8b84e			
 //612				#c4ba00			
 //612 C				#c7b000			
 //612 U				#b7a63e			
 //613				#afa00c			
 //613 C				#b59a00			
 //613 U				#a29335			
 //614				#eae2b7			
 //614 C				#ddd498			
 //614 U				#e2d8a1			
 //615				#e2dbaa			
 //615 C				#d7cd8c			
 //615 U				#dacf94			
 //616				#ddd69b			
 //616 C				#d2c780			
 //616 U				#cec387			
 //617				#ccc47c			
 //617 C				#c1b45f			
 //617 U				#bcb174			
 //618				#b5aa59			
 //618 C				#ad9d3b			
 //618 U				#a69c62			
 //619				#968c28			
 //619 C				#a09028			
 //619 U				#968c53			
 //620				#847711			
 //620 C				#8c7a16			
 //620 U				#877e48			
 //621				#d8ddce			
 //621 C				#d0e0d7			
 //621 U				#c7ded3			
 //622				#c1d1bf			
 //622 C				#b8ccc2			
 //622 U				#b0cbc1			
 //623				#a5bfaa			
 //623 C				#9ab8ac			
 //623 U				#95b4aa			
 //624				#7fa08c			
 //624 C				#789d90			
 //624 U				#809f97			
 //625				#5b8772			
 //625 C				#4f7e70			
 //625 U				#698882			
 //626				#21543f			
 //626 C				#255b4d			
 //626 U				#58746e			
 //627				#0c3026			
 //627 C				#12312a			
 //627 U				#425b57			
 //628				#cce2dd			
 //628 C				#b8dce1			
 //628 U				#b3dee6			
 //629				#b2d8d8			
 //629 C				#99d1dc			
 //629 U				#8acedd			
 //630				#8cccd3			
 //630 C				#76c3d4			
 //630 U				#72c2d7			
 //631				#54b7c6			
 //631 C				#3ab0c8			
 //631 U				#4fb0cb			
 //632				#00a0ba			
 //632 C				#0091b2			
 //632 U				#3096b4			
 //633				#007f99			
 //633 C				#007197			
 //633 U				#21809e			
 //634				#00667f			
 //634 C				#005c82			
 //634 U				#1a6c8a			
 //635				#bae0e0			
 //635 C				#a3d9e7			
 //635 U				#a9e1ee			
 //636				#99d6dd			
 //636 C				#89d2e6			
 //636 U				#85d7ee			
 //637				#6bc9db			
 //637 C				#4dc1df			
 //637 U				#58c6e5			
 //638				#00b5d6			
 //638 U				#28b5de			
 //639				#00a0c4			
 //639 C				#0093c9			
 //639 U				#009bcd			
 //640				#008cb2			
 //640 C				#0080bb			
 //640 U				#0088b9			
 //641				#007aa5			
 //641 C				#0065a0			
 //641 U				#0076a6			
 //642				#d1d8d8			
 //642 C				#d4dce5			
 //642 U				#d1deea			
 //643				#c6d1d6			
 //643 C				#c7d4e2			
 //643 U				#bfd1e4			
 //644				#9bafc4			
 //644 C				#9cb6d2			
 //644 U				#9db7d3			
 //645				#7796b2			
 //645 C				#7da0c3			
 //645 U				#83a1c4			
 //646				#5e82a3			
 //646 C				#5d89b3			
 //646 U				#6c8baf			
 //647				#26547c			
 //647 C				#265f92			
 //647 U				#5c799c			
 //648				#00305e			
 //648 C				#002c5c			
 //648 U				#4e6080			
 //649				#d6d6d8			
 //649 C				#dce1e9			
 //649 U				#dee6ed			
 //650				#bfc6d1			
 //650 C				#cfd9e5			
 //650 U				#d6dfea			
 //651				#9baabf			
 //651 C				#a8bbd5			
 //651 U				#afc2dc			
 //652				#6d87a8			
 //652 C				#7e9abf			
 //652 U				#89a1c3			
 //653				#335687			
 //653 C				#346094			
 //653 U				#687fa4			
 //654				#0f2b5b			
 //654 C				#00396f			
 //654 U				#53688c			
 //655				#0c1c47			
 //655 C				#002453			
 //655 U				#4d5b7e			
 //656				#d6dbe0			
 //656 C				#dee3eb			
 //656 U				#e1e9f2			
 //657				#c1c9dd			
 //657 C				#cad7eb			
 //657 U				#d5e0f1			
 //658				#a5afd6			
 //658 C				#b2c8e8			
 //658 U				#b8ceee			
 //659				#7f8cbf			
 //659 C				#7ba3dc			
 //659 U				#94b4e6			
 //660				#5960a8			
 //660 C				#407cc9			
 //660 U				#6289ca			
 //661				#2d338e			
 //661 C				#003494			
 //661 U				#4666aa			
 //662				#0c1975			
 //662 C				#001b70			
 //662 U				#415290			
 //663				#e2d3d6			
 //663 C				#e6e1e5			
 //663 U				#e1d8e1			
 //664				#d8ccd1			
 //664 C				#e1dae1			
 //664 U				#d9cfdc			
 //665				#c6b5c4			
 //665 C				#c8bbcf			
 //665 U				#c4b8ce			
 //666				#a893ad			
 //666 C				#a391b1			
 //666 U				#aea0bc			
 //667				#7f6689			
 //667 C				#7d6890			
 //667 U				#8f829f			
 //668				#664975			
 //668 C				#634b77			
 //668 U				#82728f			
 //669				#472b59			
 //669 C				#3f2a55			
 //669 U				#71627e			
 //670				#f2d6d8			
 //670 C				#edd2e1			
 //670 U				#f4d4e4			
 //671				#efc6d3			
 //671 C				#e9bbd7			
 //671 U				#f2c2dd			
 //672				#eaaac4			
 //672 C				#e39fc8			
 //672 U				#eca6cc			
 //673				#e08cb2			
 //673 C				#df84ba			
 //673 U				#e38bba			
 //674				#d36b9e			
 //674 C				#cd5599			
 //674 U				#d1709f			
 //675				#bc3877			
 //675 C				#b42371			
 //675 U				#c05f8d			
 //676				#a00054			
 //676 C				#9b004e			
 //676 U				#ac4f77			
 //677				#edd6d6			
 //677 C				#e8cddb			
 //677 U				#eed0e0			
 //678				#eaccce			
 //678 C				#e7c7d7			
 //678 U				#e8bfd3			
 //679				#e5bfc6			
 //679 C				#e0bdd2			
 //679 U				#dcabc6			
 //680				#d39eaf			
 //680 C				#cd94b3			
 //680 U				#c28aa7			
 //681				#b7728e			
 //681 C				#b46a94			
 //681 U				#a86e8c			
 //682				#a05175			
 //682 C				#9d4777			
 //682 U				#915c76			
 //683				#7f284f			
 //683 C				#7f2754			
 //683 U				#825166			
 //684				#efccce			
 //684 C				#e5c5d3			
 //684 U				#eccbd9			
 //685				#eabfc4			
 //685 C				#deb5c8			
 //685 U				#e4bdcf			
 //686				#e0aaba			
 //686 C				#d39fb7			
 //686 U				#d6a6bd			
 //687				#c9899e			
 //687 C				#c184a3			
 //687 U				#be8ca5			
 //688				#b26684			
 //688 C				#ab6388			
 //688 U				#a3728b			
 //689				#934266			
 //689 C				#8c3b66			
 //689 U				#8e6176			
 //690				#702342			
 //690 C				#64223f			
 //690 U				#7d4f5f			
 //691				#efd1c9			
 //691 C				#ecccce			
 //691 U				#f1d2d3			
 //692				#e8bfba			
 //692 C				#e6bec2			
 //693				#dba8a5			
 //693 C				#dba2aa			
 //693 U				#dba4ab			
 //694				#c98c8c			
 //694 C				#c7848f			
 //694 U				#c48c94			
 //695				#b26b70			
 //695 C				#b86b78			
 //695 U				#ad757e			
 //696				#8e4749			
 //696 C				#9b4755			
 //696 U				#99646b			
 //697				#7f383a			
 //697 C				#8c3b44			
 //697 U				#87555a			
 //698				#f7d1cc			
 //698 C				#f5d3d6			
 //698 U				#fbd6d9			
 //699				#f7bfbf			
 //699 U				#fec0c9			
 //700				#f2a5aa			
 //700 C				#f7acb8			
 //700 U				#f9a9b5			
 //701				#e8878e			
 //701 C				#ea8597			
 //701 U				#ec8e9d			
 //702				#d6606d			
 //702 C				#d75c71			
 //702 U				#db7886			
 //703				#b73844			
 //703 C				#bd3a49			
 //703 U				#b65a64			
 //704				#9e2828			
 //704 C				#a2292e			
 //704 U				#a54f56			
 //705				#f9ddd6			
 //705 C				#f8dadf			
 //705 U				#ffdce0			
 //706				#fcc9c6			
 //706 C				#f8cdd6			
 //706 U				#ffc9d2			
 //707				#fcadaf			
 //707 C				#fbb5c3			
 //707 U				#ffb0be			
 //708				#f98e99			
 //708 C				#fc91a2			
 //708 U				#ff97a6			
 //709				#f26877			
 //709 C				#f46177			
 //709 U				#f87b88			
 //710				#e04251			
 //710 C				#e73d50			
 //710 U				#e9636e			
 //711				#d12d33			
 //711 C				#d12a2e			
 //711 U				#d24f53			
 //712				#ffd3aa			
 //712 C				#ffc999			
 //712 U				#ffca9c			
 //713				#f9c9a3			
 //713 C				#ffbe84			
 //713 U				#ffc18f			
 //714				#f9ba82			
 //714 C				#ffa960			
 //714 U				#ffb078			
 //715				#fc9e49			
 //715 C				#f98d29			
 //715 U				#fb9a61			
 //716				#f28411			
 //716 C				#ed7700			
 //716 U				#eb854f			
 //717				#d36d00			
 //717 C				#d75e00			
 //717 U				#da763e			
 //718				#bf5b00			
 //718 C				#c14d00			
 //718 U				#c96d3c			
 //719				#f4d1af			
 //719 C				#eec7a1			
 //719 U				#f2c5a1			
 //720				#efc49e			
 //720 C				#e9b789			
 //720 U				#edba92			
 //721				#e8b282			
 //721 C				#dfa36c			
 //721 U				#dfa77e			
 //722				#d18e54			
 //722 C				#cb8241			
 //722 U				#cb916a			
 //723				#ba7530			
 //723 C				#b46a1f			
 //723 U				#b9825e			
 //724				#8e4905			
 //724 C				#954e0e			
 //724 U				#a6734e			
 //725				#753802			
 //725 C				#7f4014			
 //725 U				#966746			
 //726				#edd3b5			
 //726 C				#e2c19d			
 //726 U				#e8c5a8			
 //727				#e2bf9b			
 //727 C				#dcb38c			
 //727 U				#dcb495			
 //728				#d3a87c			
 //728 C				#cfa075			
 //728 U				#c9a081			
 //729				#c18e60			
 //729 C				#b7814f			
 //729 U				#bd9274			
 //730				#aa753f			
 //730 C				#a0662c			
 //730 U				#a47d61			
 //731				#723f0a			
 //731 C				#79420f			
 //731 U				#967155			
 //732				#60330a			
 //732 C				#64340f			
 //732 U				#89674c			
 //7401 C				#f8e0a4			
 //7401 U				#ffe3a4			
 //7402 C				#eed797			
 //7402 U				#f5d999			
 //7403 C				#f1d282			
 //7403 U				#f6ce81			
 //7404 C				#f7d93d			
 //7404 U				#ffcd3f			
 //7405 C				#f3cd00			
 //7405 U				#e7b107			
 //7406 C				#f4c300			
 //7406 U				#f2b726			
 //7407 C				#ce9f51			
 //7407 U				#cea36e			
 //7408 C				#f9be00			
 //7408 U				#f09d23			
 //7409 C				#f6b221			
 //7409 U				#fbac4e			
 //7410 C				#ffae75			
 //7410 U				#ffa06d			
 //7411 C				#eba55d			
 //7411 U				#eca06f			
 //7412 C				#d68230			
 //7412 U				#d18b5e			
 //7413 C				#e18431			
 //7413 U				#e28758			
 //7414 C				#c46c13			
 //7414 U				#c27e51			
 //7415 C				#eab8a6			
 //7415 U				#eeb3a4			
 //7416 C				#eb6851			
 //7416 U				#f0716a			
 //7417 C				#e84a37			
 //7417 U				#ed6960			
 //7418 C				#d15458			
 //7418 U				#c16364			
 //7419 C				#b24b58			
 //7419 U				#a66269			
 //7420 C				#a02040			
 //7420 U				#a75767			
 //7421 C				#6a1a31			
 //7421 U				#7e4d5a			
 //7422 C				#f6cdd3			
 //7422 U				#fdd4d8			
 //7423 C				#e46285			
 //7423 U				#e7758d			
 //7424 C				#e74582			
 //7424 U				#dc567a			
 //7425 C				#ba2253			
 //7425 U				#be5a72			
 //7426 C				#a80f3d			
 //7426 U				#b55469			
 //7427 C				#9d162e			
 //7427 U				#a9515c			
 //7428 C				#6d2a3c			
 //7428 U				#815b65			
 //7429 C				#e5bac9			
 //7429 U				#eecbd8			
 //7430 C				#e0a8be			
 //7430 U				#e8b4c8			
 //7431 C				#ce7e9c			
 //7431 U				#dfa1b8			
 //7432 C				#bb5a7f			
 //7432 U				#c78099			
 //7433 C				#ad3863			
 //7433 U				#bb6e87			
 //7434 C				#9f3058			
 //7434 U				#ab667b			
 //7435 C				#8a244e			
 //7435 U				#8e556a			
 //7436 C				#f2dae9			
 //7436 U				#f4d4ec			
 //7437 C				#cfacce			
 //7437 U				#d6b4d4			
 //7438 C				#d89dd7			
 //7438 U				#da9ad6			
 //7439 C				#b687b8			
 //7439 U				#c19cc5			
 //7440 C				#a776a5			
 //7440 U				#b894b8			
 //7441 C				#a25cbf			
 //7441 U				#b07dc9			
 //7442 C				#9a3cbb			
 //7442 U				#9e62bb			
 //7443 C				#dedae8			
 //7443 U				#ddd7ea			
 //7444 C				#b7b8dc			
 //7444 U				#bcbce1			
 //7445 C				#a8a1c1			
 //7445 U				#aca7c6			
 //7446 C				#8c85c9			
 //7446 U				#9491cf			
 //7447 C				#604775			
 //7447 U				#7e7292			
 //7448 C				#4c374b			
 //7448 U				#726774			
 //7449 C				#43263a			
 //7449 U				#63505b			
 //7450 C				#bec3d9			
 //7450 U				#c2c9df			
 //7451 C				#89a9e2			
 //7451 U				#93b1e9			
 //7452 C				#8193dc			
 //7452 U				#8fa0e4			
 //7453 C				#7ca4dd			
 //7453 U				#85abe3			
 //7454 C				#618db4			
 //7454 U				#7597bb			
 //7455 C				#3a5cac			
 //7455 U				#677cb8			
 //7456 C				#606db2			
 //7456 U				#7f88be			
 //7457 C				#bbdbe5			
 //7457 U				#bde1ec			
 //7458 C				#71b1c8			
 //7458 U				#65a4be			
 //7459 C				#4196b4			
 //7459 U				#4f8ca9			
 //7460 C				#0083c1			
 //7460 U				#008bc1			
 //7461 C				#007cba			
 //7461 U				#3e90c6			
 //7462 C				#00538a			
 //7462 U				#5479a2			
 //7463 C				#002a48			
 //7463 U				#50647d			
 //7464 C				#a1cfca			
 //7464 U				#a9d9d7			
 //7465 C				#3ebfac			
 //7465 U				#4dc4b5			
 //7466 C				#00adbb			
 //7466 U				#00b1bd			
 //7467 C				#00a0ae			
 //7467 U				#00a5b3			
 //7468 C				#007298			
 //7468 U				#3c7594			
 //7469 C				#005d85			
 //7469 U				#376c89			
 //7470 C				#00576f			
 //7470 U				#426f83			
 //7471 C				#7ddbd3			
 //7471 U				#79e0da			
 //7472 C				#5ab6b2			
 //7472 U				#67bcb8			
 //7473 C				#1e988a			
 //7473 U				#5ba39a			
 //7474 C				#007480			
 //7474 U				#3e8994			
 //7475 C				#46797a			
 //7475 U				#68898c			
 //7476 C				#075056			
 //7476 U				#57767b			
 //7477 C				#264b59			
 //7477 U				#5d6f78			
 //7478 C				#97e2be			
 //7478 U				#9be9c5			
 //7479 C				#05ce7b			
 //7479 U				#01c97f			
 //7480 C				#00bc6f			
 //7480 U				#00bf81			
 //7481 C				#00b44f			
 //7481 U				#00b76d			
 //7482 C				#009d4e			
 //7482 U				#1da46f			
 //7483 C				#235c37			
 //7483 U				#567662			
 //7484 U				#436d60			
 //7485 C				#d1ddba			
 //7485 U				#d5e3c0			
 //7486 C				#bcdf92			
 //7486 U				#b4e192			
 //7487 C				#8bdc64			
 //7487 U				#84df75			
 //7488 C				#72d54a			
 //7488 U				#5ace5a			
 //7489 C				#72a84f			
 //7489 U				#79a96b			
 //7490 C				#739849			
 //7490 U				#7a9d6c			
 //7491 C				#79843b			
 //7491 U				#808a60			
 //7492 C				#c2ca7f			
 //7492 U				#bcc986			
 //7493 C				#bdc391			
 //7493 U				#b5c093			
 //7494 C				#9cae87			
 //7494 U				#9dae90			
 //7495 C				#90993d			
 //7495 U				#828d58			
 //7496 C				#77871c			
 //7496 U				#738348			
 //7497 C				#7b7156			
 //7497 U				#8b8776			
 //7498 C				#5c6134			
 //7498 U				#767b63			
 //7499 C				#f2e4b1			
 //7499 U				#faecbb			
 //7500 C				#e1d0a5			
 //7500 U				#e6d4ab			
 //7501 C				#dac79d			
 //7501 U				#dfc9a4			
 //7502 C				#d1b786			
 //7502 U				#c9ae86			
 //7503 C				#ab9766			
 //7503 U				#9e9171			
 //7504 C				#96785d			
 //7504 U				#968171			
 //7505 C				#83603f			
 //7505 U				#887465			
 //7506 C				#f3dab1			
 //7506 U				#fbdfb7			
 //7507 C				#fed198			
 //7507 U				#ffdca9			
 //7508 C				#e2b77d			
 //7508 U				#e0b384			
 //7509 C				#d8a460			
 //7509 U				#d2a172			
 //7510 C				#c8893c			
 //7510 U				#be8b5f			
 //7511 C				#ba7726			
 //7511 U				#a8774f			
 //7512 C				#a86318			
 //7512 U				#986a47			
 //7513 C				#e3b6a4			
 //7513 U				#e7bab2			
 //7514 C				#d7a284			
 //7514 U				#dbaa9a			
 //7515 C				#c78b66			
 //7515 U				#c4907e			
 //7516 C				#9c542a			
 //7516 U				#a17462			
 //7517 C				#89421c			
 //7517 U				#946856			
 //7518 C				#6f4e46			
 //7518 U				#807070			
 //7519 C				#5f4a3b			
 //7519 U				#746a65			
 //7520 C				#edbeaf			
 //7520 U				#f3c4bf			
 //7521 C				#c49a81			
 //7521 U				#c7a095			
 //7522 C				#ba6954			
 //7522 U				#b27670			
 //7523 C				#af5c56			
 //7523 U				#ab7475			
 //7524 C				#a85147			
 //7524 U				#a56d69			
 //7525 C				#9f684f			
 //7525 U				#9b776e			
 //7526 C				#8d3a18			
 //7526 U				#935e50			
 //7527 C				#d7d1c4			
 //7527 U				#dcd6d1			
 //7528 C				#c7b9ab			
 //7528 U				#d2c7c3			
 //7529 C				#b7a998			
 //7529 U				#baaea8			
 //7530 C				#a49382			
 //7530 U				#a79b94			
 //7531 C				#7c6755			
 //7531 U				#8a7f78			
 //7532 C				#65503c			
 //7532 U				#786d64			
 //7533 C				#483627			
 //7533 U				#6d645b			
 //7534 C				#d3ccbc			
 //7534 U				#d0c9c2			
 //7535 C				#b8b09b			
 //7535 U				#c0b9b0			
 //7536 C				#a89f87			
 //7536 U				#afa79c			
 //7537 C				#a9aba0			
 //7537 U				#b3b7b5			
 //7538 C				#93998f			
 //7538 U				#a3a9a7			
 //7539 C				#8f8e88			
 //7539 U				#9b9d9f			
 //7540 C				#4b4e53			
 //7540 U				#6f737b			
 //7541 C				#dadfe1			
 //7541 U				#dae3e6			
 //7542 C				#a5bbc2			
 //7542 U				#b0c3cb			
 //7543 C				#98a3ad			
 //7543 U				#adb7c0			
 //7544 C				#768591			
 //7545 C				#425363			
 //7545 U				#77838e			
 //7546 C				#263645			
 //7546 U				#676f79			
 //7547 C				#141d28			
 //7547 U				#50525b			
 //7548 C				#ffc600			
 //7548 U				#ffc908			
 //7549 C				#ffb600			
 //7549 U				#ffb835			
 //7550 C				#d49000			
 //7550 U				#ce963b			
 //7551 C				#b57f00			
 //7551 U				#ae8542			
 //7552 C				#75531c			
 //7552 U				#816e49			
 //7553 C				#5c4520			
 //7553 U				#6f644a			
 //7554 C				#4c3d29			
 //7554 U				#6c6457			
 //7555 C				#d39e0a			
 //7555 U				#d8a958			
 //7556 C				#b88b1c			
 //7556 U				#bc985c			
 //7557 C				#a27c21			
 //7557 U				#a58c5d			
 //7558 C				#987023			
 //7558 U				#9a825d			
 //7559 C				#916928			
 //7559 U				#987e5e			
 //7560 C				#7f622c			
 //7560 U				#8e7d62			
 //7561 C				#6d5d34			
 //7561 U				#807863			
 //7562 C				#bf9a5e			
 //7562 U				#be9f77			
 //7563 C				#d99a29			
 //7563 U				#dba461			
 //7564 C				#de8a00			
 //7564 U				#df9856			
 //7565 C				#cf7a21			
 //7565 U				#ca8558			
 //7566 C				#b16432			
 //7566 U				#b0795d			
 //7567 C				#8b532e			
 //7567 U				#916f5b			
 //7568 C				#795034			
 //7568 U				#826b5d			
 //7569 C				#db8823			
 //7569 U				#d68d56			
 //7570 C				#d7832a			
 //7570 U				#d48c59			
 //7571 C				#ca7c30			
 //7571 U				#c5885b			
 //7572 C				#ba7131			
 //7572 U				#b37f5b			
 //7573 C				#aa6529			
 //7573 U				#aa7a57			
 //7574 C				#a26936			
 //7574 U				#9a7659			
 //7575 C				#855c31			
 //7575 U				#867058			
 //7576 C				#e1854e			
 //7576 U				#dd8d6a			
 //7577 C				#e57d3c			
 //7577 U				#e48961			
 //7578 C				#e06a2d			
 //7578 U				#df7c59			
 //7579 C				#e15829			
 //7579 U				#e27356			
 //7580 C				#c3502f			
 //7580 U				#c36c57			
 //7581 C				#894833			
 //7581 U				#916a5b			
 //7582 C				#694634			
 //7582 U				#7a675d			
 //7583 C				#c9602c			
 //7583 U				#cd7b5f			
 //7584 C				#c05626			
 //7584 U				#c37558			
 //7585 C				#b55a37			
 //7585 U				#b97865			
 //7586 C				#a3512f			
 //7586 U				#a56f5c			
 //7587 C				#964a2c			
 //7587 U				#9b6c5b			
 //7588 C				#7f4b35			
 //7588 U				#896c60			
 //7589 C				#5f4536			
 //7589 U				#746962			
 //7590 C				#d7b49d			
 //7590 U				#debba8			
 //7591 C				#c57c59			
 //7591 U				#c98b77			
 //7592 C				#b65332			
 //7592 U				#b87060			
 //7593 C				#a2402a			
 //7593 U				#a46659			
 //7594 C				#7f382b			
 //7594 U				#8c6259			
 //7595 C				#6e3c2e			
 //7595 U				#81655c			
 //7596 C				#5e3c31			
 //7596 U				#77655f			
 //7597 C				#d73f22			
 //7597 U				#db6655			
 //7598 C				#c24628			
 //7598 U				#c66b5a			
 //7599 C				#b73c24			
 //7599 U				#c0685a			
 //7600 C				#903e2a			
 //7600 U				#9d685d			
 //7601 C				#85412a			
 //7601 U				#93685b			
 //7602 C				#7d4930			
 //7602 U				#8d6e60			
 //7603 C				#69412f			
 //7603 U				#7c665c			
 //7604 C				#e7d4d2			
 //7604 U				#ebd6d4			
 //7605 C				#e5b9b3			
 //7605 U				#ecc3bd			
 //7606 C				#dc9089			
 //7606 U				#e39e99			
 //7607 C				#c86b60			
 //7607 U				#cf857f			
 //7608 C				#a9473c			
 //7608 U				#af6c66			
 //7609 C				#873934			
 //7609 U				#95645f			
 //7610 C				#6b3230			
 //7610 U				#81605c			
 //7611 C				#e1bbaf			
 //7611 U				#e8c7bd			
 //7612 C				#cd998d			
 //7612 U				#d5a99f			
 //7613 C				#bf887e			
 //7613 U				#c89e96			
 //7614 C				#a67e73			
 //7614 U				#af928b			
 //7615 C				#896760			
 //7615 U				#978380			
 //7616 C				#6d4b4b			
 //7616 U				#867372			
 //7617 C				#5a3c3c			
 //7617 U				#746464			
 //7618 C				#cc6c4e			
 //7618 U				#d48876			
 //7619 C				#c74a37			
 //7619 U				#cb6f63			
 //7620 C				#bd2e2a			
 //7620 U				#c55e59			
 //7621 C				#b21e27			
 //7621 U				#bf5b5a			
 //7622 C				#97252b			
 //7622 U				#a85c5c			
 //7623 C				#8f2829			
 //7623 U				#9f5a57			
 //7624 C				#852c2b			
 //7624 U				#8f5854			
 //7625 C				#e94e3c			
 //7625 U				#f0756c			
 //7626 C				#cb3524			
 //7626 U				#d5625c			
 //7627 C				#ab2b28			
 //7627 U				#b05856			
 //7628 C				#a22929			
 //7628 U				#a95957			
 //7629 C				#703231			
 //7629 U				#805b59			
 //7630 C				#65312f			
 //7630 U				#765856			
 //7631 C				#592d2b			
 //7631 U				#6e5552			
 //7632 C				#d8c9ca			
 //7632 U				#ddcecf			
 //7633 C				#c8a3a6			
 //7633 U				#cba9ad			
 //7634 C				#c66583			
 //7634 U				#cb7b90			
 //7635 C				#cd3161			
 //7635 U				#d1607b			
 //7636 C				#c41a49			
 //7636 U				#c8546d			
 //7637 C				#962c45			
 //7637 U				#975764			
 //7638 C				#832b40			
 //7638 U				#87555f			
 //7639 C				#956c72			
 //7639 U				#a08489			
 //7640 C				#973e53			
 //7640 U				#9d6572			
 //7641 C				#932a47			
 //7641 U				#9c5c6c			
 //7642 C				#752d49			
 //7642 U				#805666			
 //7643 C				#692c43			
 //7643 U				#7a5966			
 //7644 C				#5a2c3e			
 //7644 U				#725762			
 //7645 C				#522a38			
 //7645 U				#6c565f			
 //7646 C				#a96c86			
 //7646 U				#b38599			
 //7647 C				#ad3b72			
 //7647 U				#b46889			
 //7648 C				#9e1b64			
 //7648 U				#a1537b			
 //7649 C				#8e195f			
 //7649 U				#965278			
 //7650 C				#762056			
 //7650 U				#855472			
 //7651 C				#6d295a			
 //7651 U				#805b77			
 //7652 C				#612550			
 //7652 U				#74546b			
 //7653 C				#978693			
 //7653 U				#9d939e			
 //7654 C				#a6769a			
 //7654 U				#ac88a5			
 //7655 C				#a55a95			
 //7655 U				#ab779e			
 //7656 C				#93397f			
 //7656 U				#97638c			
 //7657 C				#702b62			
 //7657 U				#7f5876			
 //7658 C				#6d335e			
 //7658 U				#7c5d75			
 //7659 C				#5f3552			
 //7659 U				#6f596b			
 //7660 C				#9b8fa2			
 //7660 U				#9d95a8			
 //7661 C				#906c95			
 //7661 U				#957d9b			
 //7662 C				#7d4081			
 //7662 U				#86658b			
 //7663 C				#6d3075			
 //7663 U				#7b5c82			
 //7664 C				#683177			
 //7664 U				#765c83			
 //7665 C				#62366e			
 //7665 U				#735d7b			
 //7666 C				#5e4d62			
 //7666 U				#716876			
 //7667 C				#6f7ba0			
 //7667 U				#828ba8			
 //7668 C				#696d9f			
 //7668 U				#7b7fa3			
 //7669 C				#635d9b			
 //7669 U				#7777a1			
 //7670 C				#585094			
 //7670 U				#6f6d99			
 //7671 C				#544487			
 //7671 U				#6d6892			
 //7672 C				#4e4084			
 //7672 U				#6b658d			
 //7673 C				#545386			
 //7673 U				#6c6c8c			
 //7674 C				#8a8ab3			
 //7674 U				#9194b7			
 //7675 C				#7e7eaa			
 //7675 U				#868aae			
 //7676 C				#77649f			
 //7676 U				#8279a3			
 //7677 C				#725090			
 //7677 U				#7d6c96			
 //7678 C				#6a478d			
 //7678 U				#756591			
 //7679 C				#583c80			
 //7679 U				#6f618a			
 //7680 C				#543177			
 //7680 U				#69587f			
 //7681 C				#95a7cb			
 //7681 U				#9aaed0			
 //7682 C				#6986b7			
 //7682 U				#7f96c0			
 //7683 C				#446ba8			
 //7683 U				#6681ae			
 //7684 C				#365d9d			
 //7684 U				#6075a3			
 //7685 C				#2e5596			
 //7685 U				#5c709c			
 //7686 C				#1d4e8f			
 //7686 U				#536895			
 //7687 C				#1d4189			
 //7687 U				#4f5e8c			
 //7688 C				#4497cb			
 //7688 U				#5a98ca			
 //7689 C				#288dc0			
 //7689 U				#5292c2			
 //7690 C				#0075a8			
 //7690 U				#477ea7			
 //7691 C				#006097			
 //7691 U				#447097			
 //7692 C				#005486			
 //7692 U				#4a6a8c			
 //7693 C				#004876			
 //7693 U				#4a6381			
 //7694 U				#4c5f78			
 //7695 C				#7ca5ba			
 //7695 U				#80a7bc			
 //7696 C				#6199ae			
 //7696 U				#6e9aae			
 //7697 C				#4e869f			
 //7697 U				#688ea3			
 //7698 C				#41738c			
 //7698 U				#637e91			
 //7699 C				#35647d			
 //7699 U				#5c7588			
 //7700 C				#1c5a7c			
 //7700 U				#547088			
 //7701 C				#005677			
 //7701 U				#45697f			
 //7702 C				#45a7c5			
 //7702 U				#5aa8c7			
 //7703 C				#009abe			
 //7703 U				#419ebf			
 //7704 C				#0083ac			
 //7704 U				#2f89ac			
 //7705 C				#006e96			
 //7705 U				#387b9a			
 //7706 C				#00698e			
 //7706 U				#407895			
 //7707 C				#005f7f			
 //7707 U				#437288			
 //7708 C				#00546f			
 //7708 U				#41697d			
 //7709 C				#63b0bb			
 //7709 U				#6ab0bc			
 //7710 C				#00a5b5			
 //7710 U				#39a8b8			
 //7711 C				#0095a8			
 //7711 U				#009bac			
 //7712 C				#00829a			
 //7712 U				#1e899d			
 //7713 C				#007a89			
 //7713 U				#258492			
 //7714 C				#00747f			
 //7714 U				#2e7f8a			
 //7715 C				#006067			
 //7715 U				#3f6f77			
 //7716 C				#00948f			
 //7716 U				#439796			
 //7717 C				#00827d			
 //7717 U				#378c8b			
 //7718 C				#007473			
 //7718 U				#308082			
 //7719 C				#006b67			
 //7719 U				#3c7979			
 //7720 C				#00615b			
 //7720 U				#437575			
 //7721 C				#005c5c			
 //7721 U				#477174			
 //7722 C				#004f50			
 //7722 U				#48696e			
 //7723 C				#4ea585			
 //7723 U				#67aa91			
 //7724 C				#00946d			
 //7724 U				#4c9980			
 //7725 C				#008555			
 //7725 U				#358f71			
 //7726 C				#007a4b			
 //7726 U				#328369			
 //7727 C				#006d45			
 //7727 U				#3b7a64			
 //7728 C				#006645			
 //7728 U				#427665			
 //7729 C				#005744			
 //7729 U				#456e67			
 //7730 C				#4b9461			
 //7730 U				#659979			
 //7731 C				#208648			
 //7731 U				#55906b			
 //7732 C				#00783e			
 //7732 U				#468364			
 //7733 C				#006e42			
 //7733 U				#497a62			
 //7734 C				#286040			
 //7734 U				#567564			
 //7735 C				#37563c			
 //7735 U				#5f6f62			
 //7736 C				#385441			
 //7736 U				#5a6a62			
 //7737 C				#6ca438			
 //7737 U				#79aa66			
 //7738 C				#46a040			
 //7738 U				#63a768			
 //7739 C				#2e9941			
 //7739 U				#58a26a			
 //7740 C				#368f3f			
 //7740 U				#5a9665			
 //7741 C				#41873e			
 //7741 U				#649166			
 //7742 C				#48763a			
 //7742 U				#648464			
 //7743 C				#41683b			
 //7743 U				#5c735d			
 //7744 C				#babb13			
 //7744 U				#b8bc55			
 //7745 C				#abac21			
 //7745 U				#aeb25c			
 //7746 C				#9b9a30			
 //7746 U				#9b9e5f			
 //7747 C				#8a8c30			
 //7747 U				#8f9561			
 //7748 C				#7e7f34			
 //7748 U				#878b62			
 //7749 C				#737335			
 //7749 U				#7f8261			
 //7750 C				#666534			
 //7750 U				#767960			
 //7751 C				#cbb44a			
 //7751 U				#d1bc71			
 //7752 C				#d1ae1e			
 //7752 U				#d6b761			
 //7753 C				#c3a01c			
 //7753 U				#c6aa5c			
 //7754 C				#a28527			
 //7754 U				#a4905d			
 //7755 C				#8b752f			
 //7755 U				#90845f			
 //7756 C				#746635			
 //7756 U				#837c61			
 //7757 C				#695d31			
 //7757 U				#79745f			
 //7758 C				#d6c200			
 //7758 U				#dac856			
 //7759 C				#c6b200			
 //7759 U				#c8b751			
 //7760 C				#93832b			
 //7760 U				#958e5e			
 //7761 C				#757034			
 //7761 U				#828060			
 //7762 C				#5e6338			
 //7762 U				#727862			
 //7763 C				#5a5b3a			
 //7763 U				#707362			
 //7764 C				#545333			
 //7764 U				#6c6d5f			
 //7765 C				#bbb21e			
 //7765 U				#c0b95e			
 //7766 C				#b5a81b			
 //7766 U				#bcb25e			
 //7767 C				#ab9c2c			
 //7767 U				#b1a561			
 //7768 C				#8e7e33			
 //7768 U				#948b61			
 //7769 C				#726032			
 //7769 U				#80775d			
 //7770 C				#645937			
 //7770 U				#76715f			
 //7771 C				#4f4932			
 //7771 U				#666359			
 //801				#00aacc			
 //802				#60dd49			
 //803				#ffed38			
 //804				#ff9338			
 //805				#f95951			
 //806				#ff0093			
 //807				#d6009e			
 //808				#00b59b			
 //809				#dde00f			
 //810				#ffcc1e			
 //811				#ff7247			
 //812				#fc2366			
 //813				#e50099			
 //814				#8c60c1			
 //Black 2 C    		#332e1f            
 //Black 2 U    		#625f51            
 //Black 3 C    		#212620            
 //Black 3 U    		#575c58            
 //Black 4 C    		#31251c            
 //Black 4 U    		#685f54            
 //Black 5 C    		#3f2a2e            
 //Black 5 U    		#68595b            
 //Black 6 C    		#10181f            
 //Black 6 U    		#4a4d56            
 //Black 7 C    		#3d3834            
 //Black 7 U    		#6d6763            
 //Black C    		#2e2925            
 //Black U    		#615c59  		
 //Blue 072 C			#050d9e			
 //Blue 072 U			#3943ac			
 //Bright Red C		#f93822			
 //Cool Gray 1 C		#dad8d6			
 //Cool Gray 10 C		#646469			
 //Cool Gray 10 U		#7f8286			
 //Cool Gray 11 C		#555559			
 //Cool Gray 11 U		#797c80			
 //Cool Gray 2 C		#d2cfcd			
 //Cool Gray 2 U		#cac9c8			
 //Cool Gray 3 U		#c5c3c3			
 //Cool Gray 4 C		#bcbbba			
 //Cool Gray 4 U		#b7b6b8			
 //Cool Gray 5 C		#b3b1b1			
 //Cool Gray 5 U		#abaeb0			
 //Cool Gray 6 C		#a9a8a9			
 //Cool Gray 6 U		#a2a4a6			
 //Cool Gray 7 C		#999899			
 //Cool Gray 8 C		#8a8a8d			
 //Cool Gray 8 U		#919498			
 //Cool Gray 9 C		#777779			
 //Cool Gray 9 U		#878a8e			
 //Green C			#00a887			
 //Green U			#00a88e			
 //Orange 021 C		#ff5000			
 //Orange 021 U		#ff6d2e			
 //Pink C				#d62598			
 //Process Blue C		#0081c9			
 //Process Blue U		#0081c4			
 //Purple C			#c126b8			
 //Purple U			#c252b4			
 //Red 032 C			#f6323e			
 //Red 032 U			#fd4f57			
 //Reflex Blue C		#001588			
 //Reflex Blue U		#38499b			
 //Rhodamine Red C	#e70094			
 //Rhodamine Red U	#e94b97			
 //Rubine Red C		#d60056			
 //Rubine Red U		#e1457c			
 //Violet C			#430098			
 //Violet U			#7459b1			
 //Warm Gray 1 C		#d8d1c9			
 //Warm Gray 1 U		#dbd4cd			
 //Warm Gray 10 C		#7b6d65			
 //Warm Gray 10 U		#827a78			
 //Warm Gray 11 C		#706258			
 //Warm Gray 11 U		#7d7573			
 //Warm Gray 2 C		#cdc3bb			
 //Warm Gray 2 U		#cec7c0			
 //Warm Gray 3 C		#c1b7af			
 //Warm Gray 3 U		#beb5af			
 //Warm Gray 4 C		#b6ada4			
 //Warm Gray 4 U		#b3aaa4			
 //Warm Gray 5 C		#aea198			
 //Warm Gray 5 U		#a8a09b			
 //Warm Gray 6 U		#a29a95			
 //Warm Gray 7 C		#978b82			
 //Warm Gray 7 U		#978e8a			
 //Warm Gray 8 C		#8e8279			
 //Warm Gray 8 U		#8e8682			
 //Warm Gray 9 C		#85776f			
 //Warm Gray 9 U		#867e7c			
 //Warm Red C			#ff4337			
 //Warm Red U			#ff665b			
 //Yellow 012 C		    #ffd700			
 //Yellow C			    #ffdd00    
    }
}
