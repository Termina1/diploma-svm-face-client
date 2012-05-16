using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace svmFaceClient
{
    class Lister
    {
        private String _name;

        public Lister(String name) {
            _name = name;
        }

        public void list() {
            var files = Directory.GetDirectories(_name);
            files.ToList().ForEach((name) => {
                var sender = new ImageSender(name);
                Directory.GetFiles(name).ToList().ForEach((imageName) => {
                    sender.addImage(Image.FromFile(imageName));
                });
                sender.send();
            });
        }
    }
}
