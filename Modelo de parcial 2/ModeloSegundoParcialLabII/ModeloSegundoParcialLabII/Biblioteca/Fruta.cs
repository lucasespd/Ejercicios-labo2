﻿using System.Diagnostics.Contracts;
using System.Text;

namespace Biblioteca
{
    public abstract class Fruta
    {
        private string color;
        private double peso;

        public Fruta()
        {

        }
        public Fruta(string color, double peso) : this()
        {
            this.color = color;
            this.peso = peso;
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }
        public abstract bool TieneCarozo { get; set; }

        public virtual string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Peso: {this.Peso}");

            return sb.ToString();
        }
    }
}
