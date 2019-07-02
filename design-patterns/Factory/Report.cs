using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Report : Document

    {
        // Factory implementacion del metodo

        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
