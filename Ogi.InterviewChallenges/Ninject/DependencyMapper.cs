using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ogi.InterviewChallenges.AdventOfCode.Day2;
using Ogi.InterviewChallenges.AdventOfCode.Factories;

namespace Ogi.InterviewChallenges.Ninject
{
    class DependencyMapper : NinjectModule
    {
        public override void Load()
        {
            Bind<IElfSpreadsheetRowFactory>().To<DefaultElfSpreadsheetRowFactory>();
            Bind<IElfSpreadsheet>().To<ElfSpreadsheet>();
        }
    }
}
