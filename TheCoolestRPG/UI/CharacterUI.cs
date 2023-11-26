using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheCoolestRPG.UI
{
    internal class CharacterUI
    {
        private uint strength;
        private uint dexterity;
        private uint intelligence;
        private uint constitution;
        private uint wisdom;
        private uint charisma;
        public event PropertyChangedEventHandler? PropertyChanged;
        public CharacterUI()
        {
            strength     = 10;
            dexterity    = 10;
            intelligence = 10;
            constitution = 10;
            wisdom       = 10;
            charisma     = 10;
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public uint Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                this.strength = value;
                NotifyPropertyChanged();
            }
        }

        public uint Dexterity
        {
            get
            {
                return this.dexterity;
            }
            set
            {
                this.dexterity = value;
                NotifyPropertyChanged();
            }
        }
        public uint Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                this.intelligence = value;
                NotifyPropertyChanged();
            }
        }
        public uint Constitution
        {
            get
            {
                return this.constitution;
            }
            set
            {
                this.constitution = value;
                NotifyPropertyChanged();
            }
        }
        public uint Wisdom
        {
            get
            {
                return this.wisdom;
            }
            set
            {
                this.wisdom = value;
                NotifyPropertyChanged();
            }
        }

        public uint Charisma
        {
            get
            {
                return this.charisma;
            }
            set
            {
                this.charisma = value;
                NotifyPropertyChanged();
            }
        }

    }
}
