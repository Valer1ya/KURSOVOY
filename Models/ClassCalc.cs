using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovoyProekt.Models
{
    class ClassCalc
    {
        public ClassOutput LetsCalc(ClassInput ci)
        {
            ClassOutput co = new ClassOutput();
            co.W0 = ci.KolvoProd / (3600 * ci.HrabPech * (ci.Drabpech - 0.15));
            co.Wvert = co.W0 * 3;
            co.Fkan = ci.KolvoProd / (3600 * co.Wvert);
            co.Fkajdkan = co.Fkan / 3;
            co.dpr = (4 * ci.b * ci.L) / (2 * (ci.L + ci.b));
            co.htr = (ci.lamda * ci.Hvert * ci.p0 * Math.Pow(co.Wvert, 2) * ci.TdimaVVK) / (co.dpr * 2 * ci.T0);
            co.h90 = (2 * ci.TdimaVKP * ci.p0 * co.W0 * co.W0) / (2 * ci.T0);
            co.hcanal = (0.43 * ci.p0 * co.W0 * co.W0 * ci.TdimaVKP) / (2 * ci.T0);
            co.hsumMestn = co.h90 + co.hcanal;
            co.hgeom = ci.Hvert * 9.81 * (ci.pv * (ci.T0 / ci.TOkrV) - ci.p0 * (ci.T0 / ci.TdimaVVK));
            co.hsumV = co.htr + co.h90 + co.hcanal + co.hgeom;
            co.Fb = ci.KolvoProd / (3600 * co.Wvert);
            co.PrivD = (4 * ci.Hborov) / (2 * (ci.L + ci.Hborov));
            co.TsrB = (ci.TdimaVVK + ci.TdimaPR) / 2;
            co.htr2 = (ci.lamda * ci.Dborova * ci.p0 * co.Wvert * co.Wvert * co.TsrB) / (2 * co.dpr * ci.T0);
            co.h902 = ((2 + 0.5) * ci.p0 * co.Wvert * co.Wvert * co.TsrB) / (2 * ci.T0);
            co.hsumotVdoR = co.htr2 + co.h902;
            co.hmsrek = (0.16 * ci.p0 * co.Wvert * co.Wvert * ci.Tp) / (2 * ci.T0);
            co.Wd = (ci.W0 * ci.TsrVR) / ci.T0;
            co.hrekpuch = ci.FIs1 * ci.FIs2 * ci.FId * ci.FItst * ci.deltaH * (ci.m + 1);
            co.W0zatrub = ci.KolvoProd / (ci.HcumDlyaRek * ci.DcumDlyaRek * 3600);
            co.hmsrek2 = (0.26 * co.W0zatrub * co.W0zatrub * ci.p0 * ci.Tp1) / (2 * ci.T0);
            co.hsummestSopr = co.hmsrek2 + co.hmsrek;
            co.hrekfull = co.hsummestSopr + co.hrekpuch;
            co.Tdnauch = (ci.Tp1 + (ci.Tp1 - (1.5 * ci.Dborov))) / 2;
            co.htr3 = (ci.lamda * ci.Dborov * ci.p0 * ci.DcumDlyaRek * ci.DcumDlyaRek * co.Tdnauch) / (co.dpr * 2 * ci.T0);
            co.hsumFULL = co.htr3 + co.hrekfull + co.hsumotVdoR + co.hsumV;
            return co;
        }
    }
}
