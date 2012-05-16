using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Kayak;

namespace svmFaceClient
{
    class ImageSender
    {
        private String _label;
        private List<Image> listOfImages;

        public ImageSender(String label) {
            _label = label;
        }

        public void addImage(Image img) {
            listOfImages.Add(img);
        }

        public int send() {
            int result;
            using (var cmd = new Command()) {
                cmd.send("start " + _label);
                listOfImages.ForEach((img) => {
                    cmd.send(img);
                });
                result = cmd.send("end");
            }
            return result;
        }
    }

}
