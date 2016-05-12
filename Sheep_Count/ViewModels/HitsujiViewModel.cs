using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.ComponentModel;
using System.Media;

namespace Sheep_Count
{
	public class HitsujiViewModel : INotifyPropertyChanged
	{
        private int i = 0;
        private string message;
        private SoundPlayer sheep = new SoundPlayer(Properties.Resources.Sheep);
		public HitsujiViewModel()
		{
            this.Message = "羊が" + i.ToString() + "匹";
		}

        public string Message
        {

            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
                this.NotifyPropertyChanged("Message");
            }
        }

        public void HitsujiAdd()
        {
            i++;
            sheep.Play();
            this.Message = "羊が" + i.ToString() + "匹";
        }

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(String info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
		#endregion
	}
}