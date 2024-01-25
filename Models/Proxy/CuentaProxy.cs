namespace Proxy_DesignPattern.Models.Proxy
{
    public class CuentaProxy : ICuenta
    {
        
        private CuentaBancoAImpl cuentaReal;

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            
            if (cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);

            }
            else
            {

                return cuentaReal.depositarDinero(cuenta, monto);

            }

        }

        public string mostrarSaldo(Cuenta cuenta)
        {

            string mensaje = "";
            
            if(cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                mensaje = cuentaReal.mostrarSaldo(cuenta);

            }
            else
            {

				mensaje = cuentaReal.mostrarSaldo(cuenta);

            }

            return mensaje;

        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            
            if (cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.retirarDinero(cuenta, monto);

            }
            else
            {

                return cuentaReal.retirarDinero(cuenta, monto);

            }

        }
    }
}
