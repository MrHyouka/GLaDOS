using System.Media;
using System.IO;

namespace GLaDOS.BLL.System
{
    class AudioPlayService
    {
        public static void SoundPlay(Stream soundStream)
        {
            SoundPlayer player = new SoundPlayer(soundStream);
            player.Load();
            player.Play();
        }

        public static void SoundPlaySync(Stream soundStream)
        {
            SoundPlayer player = new SoundPlayer(soundStream);
            player.Load();
            player.PlaySync();
        }
    }
}
