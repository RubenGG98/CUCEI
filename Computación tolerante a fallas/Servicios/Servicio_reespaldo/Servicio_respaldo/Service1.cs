using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Servicio_respaldo
{
    public partial class Service1 : ServiceBase
    {
        public Timer tiempo;
        public string fecha;
        public string filename;
        public Service1()
        {
            InitializeComponent();
            tiempo = new Timer();
            tiempo.Interval = 10000;
            tiempo.Elapsed += new ElapsedEventHandler(tiempo_elapse);
            fecha=DateTime.Now.ToShortDateString().Replace("/","-");
        }

        protected override void OnStart(string[] args)
        {
            tiempo.Enabled= true;
        }

        protected override void OnStop()
        {
            tiempo.Enabled= false;
        }

        public void tiempo_elapse(object sender, EventArgs e)
        {
            if(!Directory.Exists(@"D:\\Directorio\\" + fecha))
            {
                Directory.CreateDirectory(@"D:\\Directorio\\" + fecha);
            }
            foreach(string files in Directory.GetFiles("D:\\Directorio", "*.*"))
            {
                filename=Path.GetFileName(files);
                File.Move(files, @"D:\\Directorio\\" + fecha + "\\" + filename);

            }
        }
    }
}
