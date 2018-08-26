using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace PutridParrot.Windows
{
    public class Shortcut
    {
        private ShellLink _shellLink;

        private string _arguments;
        private string _description;
        private short _hotKey;
        private string _iconLocation;
        private string _workingDirectory;
        private IntPtr _idList;
        private int _showCommand;

        public void Load(string fileName)
        {
            if (_shellLink == null)
            {
                _shellLink = new ShellLink();

                ((IPersistFile)_shellLink).Load(fileName, Shell.STGM_READ);
                var sb = new StringBuilder(Shell.MAX_PATH);

                var link = ((IShellLinkW) _shellLink);

                link.GetArguments(sb, sb.Capacity);
                _arguments = sb.ToString();

                link.GetDescription(sb, sb.Capacity);
                _description = sb.ToString();

                link.GetHotkey(out _hotKey);

                int pilcon;
                link.GetIconLocation(sb, sb.Capacity, out pilcon);
                _iconLocation = sb.ToString();

                //link.GetPath();
                link.GetIDList(out _idList);
                link.GetShowCmd(out _showCommand);
                link.GetWorkingDirectory(sb, sb.Capacity);
                _workingDirectory = sb.ToString();
            }
        }

        public string Arguments => _arguments;
        public string Description => _description;
        public short HotKey => _hotKey;
        public string IconLocation => _iconLocation;
        public string WorkingDirectory => _workingDirectory;
        public IntPtr IdList => _idList;
        public int ShowCommand => _showCommand;
    }
}
