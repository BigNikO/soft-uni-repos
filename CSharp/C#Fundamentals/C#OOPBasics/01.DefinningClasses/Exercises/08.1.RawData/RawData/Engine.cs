﻿namespace RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                this.speed = value;
            }
        }

        public int Power
        {
            get => this.power;
            set => this.power = value;
        }
    }
}
