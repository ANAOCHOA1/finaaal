using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaaal
{
    // COPIA DESDE AQUÍ
    public class Comprador
    {
        private String dni;
        private String apellidos;
        private char tipoDepartamento;
        private String distrito;
        private int cuotaInicial;
        private double cuotaMensual;
        private char estado;

        public Comprador()
        {

        }

        public void setDni(String dni)
        {
            this.dni = dni;
        }

        public String getDni()
        {
            return dni;
        }

        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }

        public void setTipoDepartamento(char tipoDepartamento)
        {
            this.tipoDepartamento = tipoDepartamento;
        }

        public char getTipoDepartamento()
        {
            return tipoDepartamento;
        }

        public void setDistrito(String distrito)
        {
            this.distrito = distrito;
        }

        public String getDistrito()
        {
            return distrito;
        }

        public void setCuotaInicial(int cuotaInicial)
        {
            this.cuotaInicial = cuotaInicial;
        }

        public int getCuotaInicial()
        {
            return cuotaInicial;
        }

        public void setCuotaMensual(double cuotaMensual)
        {
            this.cuotaMensual = cuotaMensual;
        }
        public double getCuotaMensual()
        {
            return cuotaMensual;
        }

        public void setEstado(char estado)
        {
            this.estado = estado;
        }

        public char getEstado()
        {
            return estado;
        }


    }
    // HASTA ACÁ
}
