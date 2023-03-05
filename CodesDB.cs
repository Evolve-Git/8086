﻿namespace _8086
{
    public static class CodesDB
    {
        public static string[,] codes = {   { "00", "NOP", "0" },
                                            { "01", "LXIB", "2" },
                                            { "02", "STAXB", "0" },
                                            { "03", "INXB", "0" },
                                            { "04", "INRB", "0" },
                                            { "05", "DCRB", "0" },
                                            { "06", "MVIB", "1" },
                                            { "07", "RLC", "0" },

                                            { "09", "DADB", "0" },
                                            { "0A", "LDAXB", "0" },
                                            { "0B", "DCXB", "0" },
                                            { "0C", "INRC", "0" },
                                            { "0D", "DCRC", "0" },
                                            { "0E", "MVIC", "1" },
                                            { "0F", "RRC", "0" },

                                            { "11", "LXID", "2" },
                                            { "12", "STAXD", "0" },
                                            { "13", "INXD", "0" },
                                            { "14", "INRD", "0" },
                                            { "15", "DCRD", "0" },
                                            { "16", "MVID", "1" },
                                            { "17", "RAL", "0" },

                                            { "19", "DADD", "0" },
                                            { "1A", "LDAXD", "0" },
                                            { "1B", "DCXD", "0" },
                                            { "1C", "INRE", "0" },
                                            { "1D", "DCRE", "0" },
                                            { "1E", "MVIE", "1" },
                                            { "1F", "RAR", "0" },

                                            { "21", "LXIH", "2" },
                                            { "22", "SHLD", "2" },
                                            { "23", "INXH", "0" },
                                            { "24", "INRH", "0" },
                                            { "25", "DCRH", "0" },
                                            { "26", "MVIH", "1" },
                                            { "27", "DAA", "0" },

                                            { "29", "DADH", "0" },
                                            { "2A", "LHLD", "2" },
                                            { "2B", "DCX", "0" },
                                            { "2C", "INRL", "0" },
                                            { "2D", "DCRL", "0" },
                                            { "2E", "MVIL", "1" },
                                            { "2F", "CMA", "0" },

                                            { "31", "LXISP", "2" },
                                            { "32", "STA", "2" },
                                            { "33", "INXSP", "0" },
                                            { "34", "INRM", "0" },
                                            { "35", "DCRM", "0" },
                                            { "36", "MVIM", "1" },
                                            { "37", "STC", "0" },

                                            { "39", "DADSP", "0" },
                                            { "3A", "LHLD", "2" },
                                            { "3B", "DCXSP", "0" },
                                            { "3C", "INRA", "0" },
                                            { "3D", "DCRA", "0" },
                                            { "3E", "MVIA", "1" },
                                            { "3F", "CMC", "0" },
                                            { "40", "MOVBB", "0" },
                                            { "41", "MOVBC", "0" },
                                            { "42", "MOVBD", "0" },
                                            { "43", "MOVBE", "0" },
                                            { "44", "MOVBH", "0" },
                                            { "45", "MOVBL", "0" },
                                            { "46", "MOVBM", "0" },
                                            { "47", "MOVBA", "0" },
                                            { "48", "MOVCB", "0" },
                                            { "49", "MOVCC", "0" },
                                            { "4A", "MOVCD", "0" },
                                            { "4B", "MOVCE", "0" },
                                            { "4C", "MOVCH", "0" },
                                            { "4D", "MOVCL", "0" },
                                            { "4E", "MOVCM", "0" },
                                            { "4F", "MOVCA", "0" },
                                            { "50", "MOVDB", "0" },
                                            { "51", "MOVDC", "0" },
                                            { "52", "MOVDD", "0" },
                                            { "53", "MOVDE", "0" },
                                            { "54", "MOVDH", "0" },
                                            { "55", "MOVDL", "0" },
                                            { "56", "MOVDM", "0" },
                                            { "57", "MOVDA", "0" },
                                            { "58", "MOVEB", "0" },
                                            { "59", "MOVEC", "0" },
                                            { "5A", "MOVED", "0" },
                                            { "5B", "MOVEE", "0" },
                                            { "5C", "MOVEH", "0" },
                                            { "5D", "MOVEL", "0" },
                                            { "5E", "MOVEM", "0" },
                                            { "5F", "MOVEA", "0" },
                                            { "60", "MOVHB", "0" },
                                            { "61", "MOVHC", "0" },
                                            { "62", "MOVHD", "0" },
                                            { "63", "MOVHE", "0" },
                                            { "64", "MOVHH", "0" },
                                            { "65", "MOVHL", "0" },
                                            { "66", "MOVHM", "0" },
                                            { "67", "MOVHA", "0" },
                                            { "68", "MOVLB", "0" },
                                            { "69", "MOVLC", "0" },
                                            { "6A", "MOVLD", "0" },
                                            { "6B", "MOVLE", "0" },
                                            { "6C", "MOVLH", "0" },
                                            { "6D", "MOVLL", "0" },
                                            { "6E", "MOVLM", "0" },
                                            { "6F", "MOVLA", "0" },
                                            { "70", "MOVMB", "0" },
                                            { "71", "MOVMC", "0" },
                                            { "72", "MOVMD", "0" },
                                            { "73", "MOVME", "0" },
                                            { "74", "MOVMH", "0" },
                                            { "75", "MOVML", "0" },
                                            { "76", "HLT", "0" },
                                            { "77", "MOVMA", "0" },
                                            { "78", "MOVAB", "0" },
                                            { "79", "MOVAC", "0" },
                                            { "7A", "MOVAD", "0" },
                                            { "7B", "MOVAE", "0" },
                                            { "7C", "MOVAH", "0" },
                                            { "7D", "MOVAL", "0" },
                                            { "7E", "MOVAM", "0" },
                                            { "7F", "MOVAA", "0" },
                                            { "80", "ADDB", "0" },
                                            { "81", "ADDC", "0" },
                                            { "82", "ADDD", "0" },
                                            { "83", "ADDE", "0" },
                                            { "84", "ADDH", "0" },
                                            { "85", "ADDL", "0" },
                                            { "86", "ADDM", "0" },
                                            { "87", "ADDA", "0" },
                                            { "88", "ADCB", "0" },
                                            { "89", "ADCC", "0" },
                                            { "8A", "ADCD", "0" },
                                            { "8B", "ADCE", "0" },
                                            { "8C", "ADCH", "0" },
                                            { "8D", "ADCL", "0" },
                                            { "8E", "ADCM", "0" },
                                            { "8F", "ADCA", "0" },
                                            { "90", "SUBB", "0" },
                                            { "91", "SUBC", "0" },
                                            { "92", "SUBD", "0" },
                                            { "93", "SUBE", "0" },
                                            { "94", "SUBH", "0" },
                                            { "95", "SUBL", "0" },
                                            { "96", "SUBM", "0" },
                                            { "97", "SUBA", "0" },
                                            { "98", "SBBB", "0" },
                                            { "99", "SBBC", "0" },
                                            { "9A", "SBBD", "0" },
                                            { "9B", "SBBE", "0" },
                                            { "9C", "SBBH", "0" },
                                            { "9D", "SBBL", "0" },
                                            { "9E", "SBBM", "0" },
                                            { "9F", "SBBA", "0" },
                                            { "A0", "ANAB", "0" },
                                            { "A1", "ANAC", "0" },
                                            { "A2", "ANAD", "0" },
                                            { "A3", "ANAE", "0" },
                                            { "A4", "ANAH", "0" },
                                            { "A5", "ANAL", "0" },
                                            { "A6", "ANAM", "0" },
                                            { "A7", "ANAA", "0" },
                                            { "A8", "XRAB", "0" },
                                            { "A9", "XRAC", "0" },
                                            { "AA", "XRAD", "0" },
                                            { "AB", "XRAE", "0" },
                                            { "AC", "XRAH", "0" },
                                            { "AD", "XRAL", "0" },
                                            { "AE", "XRAM", "0" },
                                            { "AF", "XRAA", "0" },
                                            { "B0", "ORAB", "0" },
                                            { "B1", "ORAC", "0" },
                                            { "B2", "ORAD", "0" },
                                            { "B3", "ORAE", "0" },
                                            { "B4", "ORAH", "0" },
                                            { "B5", "ORAL", "0" },
                                            { "B6", "ORAM", "0" },
                                            { "B7", "ORAA", "0" },
                                            { "B8", "CMPB", "0" },
                                            { "B9", "CMPC", "0" },
                                            { "BA", "CMPD", "0" },
                                            { "BB", "CMPE", "0" },
                                            { "BC", "CMPH", "0" },
                                            { "BD", "CMPL", "0" },
                                            { "BE", "CMPM", "0" },
                                            { "BF", "CMPA", "0" },
                                            { "C0", "RNZ", "0" },
                                            { "C1", "POPB", "0" },
                                            { "C2", "JNZ", "2" },
                                            { "C3", "JMP", "2" },
                                            { "C4", "CNZ", "2" },
                                            { "C5", "PUSHB", "0" },
                                            { "C6", "ADI", "1" },
                                            { "C7", "RST0", "0" },
                                            { "C8", "RZ", "0" },
                                            { "C9", "RET", "0" },
                                            { "CA", "JZ", "2" },

                                            { "CC", "CZ", "2" },
                                            { "CD", "CALL", "2" },
                                            { "CE", "ACI", "1" },
                                            { "CF", "RST1", "0" },
                                            { "D0", "RNC", "0" },
                                            { "D1", "POPD", "0" },
                                            { "D2", "JNC", "2" },
                                            { "D3", "OUT", "1" },
                                            { "D4", "CNC", "2" },
                                            { "D5", "PUSHD", "0" },
                                            { "D6", "SUI", "1" },
                                            { "D7", "RST2", "0" },
                                            { "D8", "RC", "0" },

                                            { "DA", "JC", "2" },
                                            { "DB", "IN", "1" },
                                            { "DC", "CC", "2" },

                                            { "DE", "SBI", "1" },
                                            { "DF", "RST3", "0" },
                                            { "E0", "RPO", "0" },
                                            { "E1", "POPH", "0" },
                                            { "E2", "JPO", "0" },
                                            { "E3", "XTHL", "0" },
                                            { "E4", "CPO", "2" },
                                            { "E5", "PUSHH", "0" },
                                            { "E6", "ANI", "1" },
                                            { "E7", "RST4", "0" },
                                            { "E8", "RPE", "0" },
                                            { "E9", "PCHL", "0" },
                                            { "EA", "JPE", "2" },
                                            { "EB", "XCHG", "0" },
                                            { "EC", "CPE", "2" },

                                            { "EE", "XRI", "1" },
                                            { "EF", "RST5", "0" },
                                            { "F0", "RP", "0" },
                                            { "F1", "POPPSW", "0" },
                                            { "F2", "JP", "2" },
                                            { "F3", "DI", "0" },
                                            { "F4", "CP", "2" },
                                            { "F5", "PUSHPSW", "0" },
                                            { "F6", "ORI", "1" },
                                            { "F7", "RST6", "0" },
                                            { "F8", "RM", "0" },
                                            { "F9", "SPHL", "0" },
                                            { "FA", "JM", "2" },
                                            { "FB", "EI", "0" },
                                            { "FC", "CM", "2" },

                                            { "FE", "CPI", "1" },
                                            { "FF", "RST7", "0" }
                                        } ;
    }
}
