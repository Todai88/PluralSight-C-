using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidThinking.CLI
{
    public class ArgumentParser
    {
        private string[] _arguments { get; set; }

        public ArgumentParser(string[] Arguments)
        {
            _arguments = Arguments;
        }

        public bool ContainsIllegalOptions()
        {
            if(_arguments.Length > 1)
            {
                return _arguments.Skip(1).Any(x => x != "-w" || x != "-l" || x != "-v");
            }
            return false;
        }

        public void ParseArguments()
        {

        }
    }
}
