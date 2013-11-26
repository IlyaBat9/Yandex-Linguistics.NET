﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YandexLinguistics.NET
{
	public struct LangPair
	{
		public Lang InputLang;
		public Lang OutputLang;

		// Dictionary directions
		public static readonly LangPair RuRu = new LangPair(Lang.Ru, Lang.Ru);
		public static readonly LangPair RuEn = new LangPair(Lang.Ru, Lang.En);
		public static readonly LangPair RuPl = new LangPair(Lang.Ru, Lang.Pl);
		public static readonly LangPair RuUk = new LangPair(Lang.Ru, Lang.Uk);
		public static readonly LangPair RuDe = new LangPair(Lang.Ru, Lang.De);
		public static readonly LangPair RuFr = new LangPair(Lang.Ru, Lang.Fr);
		public static readonly LangPair RuEs = new LangPair(Lang.Ru, Lang.Es);
		public static readonly LangPair RuIt = new LangPair(Lang.Ru, Lang.It);
		public static readonly LangPair RuTr = new LangPair(Lang.Ru, Lang.Tr);
		public static readonly LangPair EnRu = new LangPair(Lang.En, Lang.Ru);
		public static readonly LangPair EnEn = new LangPair(Lang.En, Lang.En);
		public static readonly LangPair EnDe = new LangPair(Lang.En, Lang.De);
		public static readonly LangPair EnFr = new LangPair(Lang.En, Lang.Fr);
		public static readonly LangPair EnEs = new LangPair(Lang.En, Lang.Es);
		public static readonly LangPair EnIt = new LangPair(Lang.En, Lang.It);
		public static readonly LangPair EnTr = new LangPair(Lang.En, Lang.Tr);
		public static readonly LangPair PlRu = new LangPair(Lang.Pl, Lang.Ru);
		public static readonly LangPair UkRu = new LangPair(Lang.Uk, Lang.Ru);
		public static readonly LangPair DeRu = new LangPair(Lang.De, Lang.Ru);
		public static readonly LangPair DeEn = new LangPair(Lang.De, Lang.En);
		public static readonly LangPair FrRu = new LangPair(Lang.Fr, Lang.Ru);
		public static readonly LangPair FrEn = new LangPair(Lang.Fr, Lang.En);
		public static readonly LangPair EsRu = new LangPair(Lang.Es, Lang.Ru);
		public static readonly LangPair EsEn = new LangPair(Lang.Es, Lang.En);
		public static readonly LangPair ItRu = new LangPair(Lang.It, Lang.Ru);
		public static readonly LangPair ItEn = new LangPair(Lang.It, Lang.En);
		public static readonly LangPair TrRu = new LangPair(Lang.Tr, Lang.Ru);
		public static readonly LangPair TrEn = new LangPair(Lang.Tr, Lang.En);

		// Translator directions
		public static readonly LangPair AzRu = new LangPair(Lang.Az, Lang.Ru);
		public static readonly LangPair BeBg = new LangPair(Lang.Be, Lang.Bg);
		public static readonly LangPair BeCs = new LangPair(Lang.Be, Lang.Cs);
		public static readonly LangPair BeDe = new LangPair(Lang.Be, Lang.De);
		public static readonly LangPair BeEn = new LangPair(Lang.Be, Lang.En);
		public static readonly LangPair BeEs = new LangPair(Lang.Be, Lang.Es);
		public static readonly LangPair BeFr = new LangPair(Lang.Be, Lang.Fr);
		public static readonly LangPair BeIt = new LangPair(Lang.Be, Lang.It);
		public static readonly LangPair BePl = new LangPair(Lang.Be, Lang.Pl);
		public static readonly LangPair BeRo = new LangPair(Lang.Be, Lang.Ro);
		public static readonly LangPair BeRu = new LangPair(Lang.Be, Lang.Ru);
		public static readonly LangPair BeSr = new LangPair(Lang.Be, Lang.Sr);
		public static readonly LangPair BeTr = new LangPair(Lang.Be, Lang.Tr);
		public static readonly LangPair BgBe = new LangPair(Lang.Bg, Lang.Be);
		public static readonly LangPair BgRu = new LangPair(Lang.Bg, Lang.Ru);
		public static readonly LangPair BgUk = new LangPair(Lang.Bg, Lang.Uk);
		public static readonly LangPair CaEn = new LangPair(Lang.Ca, Lang.En);
		public static readonly LangPair CaRu = new LangPair(Lang.Ca, Lang.Ru);
		public static readonly LangPair CsBe = new LangPair(Lang.Cs, Lang.Be);
		public static readonly LangPair CsEn = new LangPair(Lang.Cs, Lang.En);
		public static readonly LangPair CsRu = new LangPair(Lang.Cs, Lang.Ru);
		public static readonly LangPair CsUk = new LangPair(Lang.Cs, Lang.Uk);
		public static readonly LangPair DaEn = new LangPair(Lang.Da, Lang.En);
		public static readonly LangPair DaRu = new LangPair(Lang.Da, Lang.Ru);
		public static readonly LangPair DeBe = new LangPair(Lang.De, Lang.Be);
		public static readonly LangPair DeEs = new LangPair(Lang.De, Lang.Es);
		public static readonly LangPair DeFr = new LangPair(Lang.De, Lang.Fr);
		public static readonly LangPair DeIt = new LangPair(Lang.De, Lang.It);
		public static readonly LangPair DeTr = new LangPair(Lang.De, Lang.Tr);
		public static readonly LangPair DeUk = new LangPair(Lang.De, Lang.Uk);
		public static readonly LangPair ElEn = new LangPair(Lang.El, Lang.En);
		public static readonly LangPair ElRu = new LangPair(Lang.El, Lang.Ru);
		public static readonly LangPair EnBe = new LangPair(Lang.En, Lang.Be);
		public static readonly LangPair EnCa = new LangPair(Lang.En, Lang.Ca);
		public static readonly LangPair EnCs = new LangPair(Lang.En, Lang.Cs);
		public static readonly LangPair EnDa = new LangPair(Lang.En, Lang.Da);
		public static readonly LangPair EnEl = new LangPair(Lang.En, Lang.El);
		public static readonly LangPair EnEt = new LangPair(Lang.En, Lang.Et);
		public static readonly LangPair EnFi = new LangPair(Lang.En, Lang.Fi);
		public static readonly LangPair EnHu = new LangPair(Lang.En, Lang.Hu);
		public static readonly LangPair EnLt = new LangPair(Lang.En, Lang.Lt);
		public static readonly LangPair EnLv = new LangPair(Lang.En, Lang.Lv);
		public static readonly LangPair EnMk = new LangPair(Lang.En, Lang.Mk);
		public static readonly LangPair EnNl = new LangPair(Lang.En, Lang.Nl);
		public static readonly LangPair EnNo = new LangPair(Lang.En, Lang.No);
		public static readonly LangPair EnPt = new LangPair(Lang.En, Lang.Pt);
		public static readonly LangPair EnSk = new LangPair(Lang.En, Lang.Sk);
		public static readonly LangPair EnSl = new LangPair(Lang.En, Lang.Sl);
		public static readonly LangPair EnSq = new LangPair(Lang.En, Lang.Sq);
		public static readonly LangPair EnSv = new LangPair(Lang.En, Lang.Sv);
		public static readonly LangPair EnUk = new LangPair(Lang.En, Lang.Uk);
		public static readonly LangPair EsBe = new LangPair(Lang.Es, Lang.Be);
		public static readonly LangPair EsDe = new LangPair(Lang.Es, Lang.De);
		public static readonly LangPair EsUk = new LangPair(Lang.Es, Lang.Uk);
		public static readonly LangPair EtEn = new LangPair(Lang.Et, Lang.En);
		public static readonly LangPair EtRu = new LangPair(Lang.Et, Lang.Ru);
		public static readonly LangPair FiEn = new LangPair(Lang.Fi, Lang.En);
		public static readonly LangPair FiRu = new LangPair(Lang.Fi, Lang.Ru);
		public static readonly LangPair FrBe = new LangPair(Lang.Fr, Lang.Be);
		public static readonly LangPair FrDe = new LangPair(Lang.Fr, Lang.De);
		public static readonly LangPair FrUk = new LangPair(Lang.Fr, Lang.Uk);
		public static readonly LangPair HrRu = new LangPair(Lang.Hr, Lang.Ru);
		public static readonly LangPair HuEn = new LangPair(Lang.Hu, Lang.En);
		public static readonly LangPair HuRu = new LangPair(Lang.Hu, Lang.Ru);
		public static readonly LangPair HyRu = new LangPair(Lang.Hy, Lang.Ru);
		public static readonly LangPair ItBe = new LangPair(Lang.It, Lang.Be);
		public static readonly LangPair ItDe = new LangPair(Lang.It, Lang.De);
		public static readonly LangPair ItUk = new LangPair(Lang.It, Lang.Uk);
		public static readonly LangPair LtEn = new LangPair(Lang.Lt, Lang.En);
		public static readonly LangPair LtRu = new LangPair(Lang.Lt, Lang.Ru);
		public static readonly LangPair LvEn = new LangPair(Lang.Lv, Lang.En);
		public static readonly LangPair LvRu = new LangPair(Lang.Lv, Lang.Ru);
		public static readonly LangPair MkEn = new LangPair(Lang.Mk, Lang.En);
		public static readonly LangPair MkRu = new LangPair(Lang.Mk, Lang.Ru);
		public static readonly LangPair NlEn = new LangPair(Lang.Nl, Lang.En);
		public static readonly LangPair NlRu = new LangPair(Lang.Nl, Lang.Ru);
		public static readonly LangPair NoEn = new LangPair(Lang.No, Lang.En);
		public static readonly LangPair NoRu = new LangPair(Lang.No, Lang.Ru);
		public static readonly LangPair PlBe = new LangPair(Lang.Pl, Lang.Be);
		public static readonly LangPair PlUk = new LangPair(Lang.Pl, Lang.Uk);
		public static readonly LangPair PtEn = new LangPair(Lang.Pt, Lang.En);
		public static readonly LangPair PtRu = new LangPair(Lang.Pt, Lang.Ru);
		public static readonly LangPair RoBe = new LangPair(Lang.Ro, Lang.Be);
		public static readonly LangPair RoRu = new LangPair(Lang.Ro, Lang.Ru);
		public static readonly LangPair RoUk = new LangPair(Lang.Ro, Lang.Uk);
		public static readonly LangPair RuAz = new LangPair(Lang.Ru, Lang.Az);
		public static readonly LangPair RuBe = new LangPair(Lang.Ru, Lang.Be);
		public static readonly LangPair RuBg = new LangPair(Lang.Ru, Lang.Bg);
		public static readonly LangPair RuCa = new LangPair(Lang.Ru, Lang.Ca);
		public static readonly LangPair RuCs = new LangPair(Lang.Ru, Lang.Cs);
		public static readonly LangPair RuDa = new LangPair(Lang.Ru, Lang.Da);
		public static readonly LangPair RuEl = new LangPair(Lang.Ru, Lang.El);
		public static readonly LangPair RuEt = new LangPair(Lang.Ru, Lang.Et);
		public static readonly LangPair RuFi = new LangPair(Lang.Ru, Lang.Fi);
		public static readonly LangPair RuHr = new LangPair(Lang.Ru, Lang.Hr);
		public static readonly LangPair RuHu = new LangPair(Lang.Ru, Lang.Hu);
		public static readonly LangPair RuHy = new LangPair(Lang.Ru, Lang.Hy);
		public static readonly LangPair RuLt = new LangPair(Lang.Ru, Lang.Lt);
		public static readonly LangPair RuLv = new LangPair(Lang.Ru, Lang.Lv);
		public static readonly LangPair RuMk = new LangPair(Lang.Ru, Lang.Mk);
		public static readonly LangPair RuNl = new LangPair(Lang.Ru, Lang.Nl);
		public static readonly LangPair RuNo = new LangPair(Lang.Ru, Lang.No);
		public static readonly LangPair RuPt = new LangPair(Lang.Ru, Lang.Pt);
		public static readonly LangPair RuRo = new LangPair(Lang.Ru, Lang.Ro);
		public static readonly LangPair RuSk = new LangPair(Lang.Ru, Lang.Sk);
		public static readonly LangPair RuSl = new LangPair(Lang.Ru, Lang.Sl);
		public static readonly LangPair RuSq = new LangPair(Lang.Ru, Lang.Sq);
		public static readonly LangPair RuSr = new LangPair(Lang.Ru, Lang.Sr);
		public static readonly LangPair RuSv = new LangPair(Lang.Ru, Lang.Sv);
		public static readonly LangPair SkEn = new LangPair(Lang.Sk, Lang.En);
		public static readonly LangPair SkRu = new LangPair(Lang.Sk, Lang.Ru);
		public static readonly LangPair SlEn = new LangPair(Lang.Sl, Lang.En);
		public static readonly LangPair SlRu = new LangPair(Lang.Sl, Lang.Ru);
		public static readonly LangPair SqEn = new LangPair(Lang.Sq, Lang.En);
		public static readonly LangPair SqRu = new LangPair(Lang.Sq, Lang.Ru);
		public static readonly LangPair SrBe = new LangPair(Lang.Sr, Lang.Be);
		public static readonly LangPair SrRu = new LangPair(Lang.Sr, Lang.Ru);
		public static readonly LangPair SrUk = new LangPair(Lang.Sr, Lang.Uk);
		public static readonly LangPair SvEn = new LangPair(Lang.Sv, Lang.En);
		public static readonly LangPair SvRu = new LangPair(Lang.Sv, Lang.Ru);
		public static readonly LangPair TrBe = new LangPair(Lang.Tr, Lang.Be);
		public static readonly LangPair TrDe = new LangPair(Lang.Tr, Lang.De);
		public static readonly LangPair TrUk = new LangPair(Lang.Tr, Lang.Uk);
		public static readonly LangPair UkBg = new LangPair(Lang.Uk, Lang.Bg);
		public static readonly LangPair UkCs = new LangPair(Lang.Uk, Lang.Cs);
		public static readonly LangPair UkDe = new LangPair(Lang.Uk, Lang.De);
		public static readonly LangPair UkEn = new LangPair(Lang.Uk, Lang.En);
		public static readonly LangPair UkEs = new LangPair(Lang.Uk, Lang.Es);
		public static readonly LangPair UkFr = new LangPair(Lang.Uk, Lang.Fr);
		public static readonly LangPair UkIt = new LangPair(Lang.Uk, Lang.It);
		public static readonly LangPair UkPl = new LangPair(Lang.Uk, Lang.Pl);
		public static readonly LangPair UkRo = new LangPair(Lang.Uk, Lang.Ro);
		public static readonly LangPair UkSr = new LangPair(Lang.Uk, Lang.Sr);
		public static readonly LangPair UkTr = new LangPair(Lang.Uk, Lang.Tr);

		public LangPair(Lang inputLang, Lang outputLang)
		{
			InputLang = inputLang;
			OutputLang = outputLang;
		}

		public LangPair(string langPair)
		{
			var inOut = langPair.Split('-');
			InputLang = (Lang)Enum.Parse(typeof(Lang), inOut[0].Remove(1).ToUpperInvariant() + inOut[0].Substring(1));
			OutputLang = (Lang)Enum.Parse(typeof(Lang), inOut[1].Remove(1).ToUpperInvariant() + inOut[1].Substring(1));
		}

		public override string ToString()
		{
			return InputLang.ToString() + "-" + OutputLang.ToString();
		}
	}
}
