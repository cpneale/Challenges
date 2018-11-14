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
            Bind<IElfSpreadsheet>().To<ElfSpreadsheetModulo>();
        }
    }
}
