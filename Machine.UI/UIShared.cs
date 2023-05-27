using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine.UI
{
    internal static class UIShared
    {
        static UIShared()
        {
            if (1 == 1)// 適当な条件文にしている。実際は設定ファイルの値等で判断します。
            {
                MachineFacade = new DummyMachineFacade();

            }
            MachineFacade = new MachineFacade();
        }
        internal static IMachineFacede MachineFacade { get; }
    }
}
