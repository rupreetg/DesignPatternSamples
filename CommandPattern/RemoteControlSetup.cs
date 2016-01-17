using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControlSetup
    {
        public RemoteControl InitializeRemote()
        {
            VolumeControl volume = new VolumeControl();
            ICommand volumeCommand = new VolumeChangeCommand(volume);

            ChannelControl channel = new ChannelControl();
            ICommand channelCommand = new ChannelChangeCommand(channel);

            RemoteControl remote = new RemoteControl();
            remote.RegisterCommand(volumeCommand);
            remote.RegisterCommand(channelCommand);

            remote.ExecuteButtonPressed(volumeCommand);

            remote.UndoButtonPressed(channelCommand);

            return remote;
        }
    }
}
