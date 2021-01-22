using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursovoyProekt.Models
{

    public class ClassInput
    {
        public double KolvoProd { get; set; }
        public double p0 { get; set; }
        public double pv { get; set; }
        public double HrabPech { get; set; }
        public double Drabpech { get; set; }
        public double TdimaVKP { get; set; }
        public double TdimaVVK { get; set; }
        public double L { get; set; }
        public double b { get; set; }
        public double Hvert { get; set; }
        public double lamda { get; set; }
        public double Dborova { get; set; }
        public double TdimaPR { get; set; }
        public double TOkrV { get; set; }
        public double Hborov { get; set; }
        public double Dborov { get; set; }
        public double T0 { get; set; }
        public double PadTdimavRek { get; set; }
        public double HcumDlyaRek { get; set; }
        public double DcumDlyaRek { get; set; }
        public double dTrub { get; set; }
        public double s1s22d { get; set; }
        public double Tp { get; set; }
        public double Tp1 { get; set; }
        public double TsrVR { get; set; }
        public double W0 { get; set; }
        public double m { get; set; }
        public double Tst { get; set; }
        public double deltaH { get; set; }
        public double FIs1 { get; set; }
        public double FIs2 { get; set; }
        public double FId { get; set; }
        public double FItst { get; set; }

        public static ClassInput Default()
        {
            return new ClassInput()
            {
                b = 0.7,
                Dborov = 6,
                Dborova = 11,
                DcumDlyaRek = 2.5,
                deltaH = 8,
                dTrub = 57,
                Drabpech = 2.15,
                FId = 1.11,
                FIs1 = 0.95,
                FIs2 = 1,
                FItst = 1.06,
                Hborov = 2.15,
                HcumDlyaRek = 1.4,
                HrabPech = 3.55,
                Hvert = 3,
                KolvoProd = 19165,
                L = 1,
                lamda = 0.05,
                m = 14,
                p0 = 1.28,
                PadTdimavRek = 450,
                pv = 1.29,
                s1s22d = 114,
                T0 = 273,
                TdimaPR = 1176,
                TdimaVKP = 1223,
                TdimaVVK = 1198,
                TOkrV = 293,
                Tp = 1176,
                Tp1 = 726,
                TsrVR = 951,
                Tst = 593,
                W0 = 4
            };
        }
    }
}
