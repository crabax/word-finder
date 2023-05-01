﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinderTest
{
    public static class Consts
    {
        public static List<string> Matrix5x5 => new()
        {
            "abcdc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy"
        };

        public static List<string> Matrix15x15 => new()
        {
            "abcdcabcdcabcdc",
            "fgwiofgwiofgwio",
            "chillffiffffiff",
            "pqnsdpqnsdpqnsd",
            "snowyuvdxychill",
            "nffffffffffffff",
            "offffffffffffff",
            "wfffffffffwffff",
            "cfffffffffiffff",
            "hfffffffffnffff",
            "ifffffffffdffff",
            "lffffffffffffff",
            "lffffffffffffff",
            "chartfffffchart",
            "fffffffffffffff",
        };

        public static List<string> Matrix64x64 => new()
        {
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffwindffffffffffffffff",
            "fffffffffffffffffffffffffffffffffffffffffffffcartfffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffcfffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffofffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffflfffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffdfffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffcffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffhffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffifffffffffffffffffffffffffffffffsffffffffffffffffffff",
            "ffffffffffflfwindffffffffffffffffffffffffffnffffffffffffffffffff",
            "ffffffffffflfffffffffffffffffffffffffffffffoffffffffffffffffffff",
            "fffffffffffffffffffffffffffffffffffffffffffwffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffcfffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffhfffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffifffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffflfffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffflfffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffsffffffffffffffffsffffffffffffffffffffffffffffffffffff",
            "ffffffffffnffffffffffffffffnffffffffffffffffffffffffffffffffffff",
            "ffffffffffoffffffffffffffffoffffffffffffffffffffffffffffffffffff",
            "ffffffffffwffffffffffffcfffwffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffoffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffflffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffdffffffffffffffffffffffffchillfffffffffff",
            "fffffffffffffffffffffffffffchillffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffsnowffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffsff",
            "fffffffffffffffffffffffffffffffffffffffffffffffffwindffffffffnff",
            "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffoff",
            "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffwff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff"
        };

        public static List<string> Matrix64x64_v2 => new()
        {
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffflfffffffffffffffffffkfffffffffffffffffffffffffffffffffffffff",
            "ffffaffjfffffffffffffffinfffffffffffffffffffffffffffffffffffffff",
            "ffffvffafffffffffffffffrofmoonffffffffffffffffffffffffffffffffff",
            "ffffaffdfffffffffffffffitfffffffffffffffffffffffffffffffffffffff",
            "fffffffefffffffffffffffsffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "birdffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffgfffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffitffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffruffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffflsffffffffffffffffffffffffffffffffffqfffffffffff",
            "fffffffffffffffffkffffffffffffffffffffffffffffffffffufffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffafffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffyfffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffdfffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffufffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffsfffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffkfffffffffffff",
            "ffffffffffffffffffffffffffffffffffffofffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffnfffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffyfffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffxfffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffvaseffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffffhopeffffffffffffffffechofffffffffffffff",
            "fffffffffffffffffffffffffffffffffaffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffffffffffffrffffffffffffffffffffffffffffff",
            "fffffffffffffffffcfffffffffffffffcffffffffffffffffffffffffffffff",
            "ffsfffffffffffffflfffffffffffffffhffffffffffffffffffffffffffffff",
            "ffaffffffffffffffafnffffffffffffffffffffffffffffffffffffffffffff",
            "ffnffffffffffffffyfeffffffffffffffffffffffffffffffffffffffffffff",
            "ffdffffffffffffffffsffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffftffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffrainfff",
            "ffffffffffffffffffffpearffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
            "ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff",
        };
    }
}
