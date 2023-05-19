using MySql.Data.MySqlClient;
//using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Urbiautos
{
    public class DataConn
    {
        public string ConnectionString = SetString();
        public static string SetString()
        {
            switch (CheckConn())
            {
                /*case true:
                    {
                        return "Server=remotemysql.com; Port=3306; Database=YyPU5GjIGr; User=YyPU5GjIGr; Password=";
                    }*/
                default://case false:
                    {
                        string constring = "server="+Properties.Settings.Default.IPDB+";user="+ Properties.Settings.Default.DBUSER+ ";password="+ Properties.Settings.Default.+ ";database=urbiautos;";
                        /*string file = String.Format(@"{0}\UrbiAutosDB.sql", Application.StartupPath);
                        using (MySqlConnection conn = new MySqlConnection(constring))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ImportFromFile(file);
                                    conn.Close();
                                }
                            }
                        }*/
                        return constring;
                    }
                /*default:
                    {
                        return "";
                    }*/
            }
        }
        public void EditInventarioNum(String Item, String Modified, int Cant)
        {
            try
            {
                String query = "UPDATE Productos SET " + Modified + "= ?cant WHERE Codigo = ?cod";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?cant", MySqlDbType.Int32).Value = Cant;
                        cmd.Parameters.Add("?cod", MySqlDbType.VarString).Value = Item;
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public void EditInventarioString(String Item, String Modified, String Cant)
        {
            try
            {
                String query = "UPDATE Productos SET " + Modified + "= ?cant WHERE Codigo = ?cod";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?cant", MySqlDbType.String).Value = Cant;
                        cmd.Parameters.Add("?cod", MySqlDbType.VarString).Value = Item;
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public void Backup()
        {
            string offfile = String.Format(@"{0}\UrbiAutosDBOffline.sql", Application.StartupPath);
            if (IsFileLocked(new FileInfo(offfile)) && File.Exists(offfile))
            {
                MessageBox.Show("El archivo de respaldo está siendo usado por otro proceso", "Archivo en Uso",
                                    MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportToFile(offfile);
                                conn.Close();
                            }
                        }
                    }
                }
                catch
                {
                    //XD
                }
            }
        }
        /*
            else
            {
                string file = String.Format(@"{0}\UrbiAutosDB.sql", Application.StartupPath);
                if (IsFileLocked(new FileInfo(file)) && File.Exists(file))
                {
                    MessageBox.Show("El archivo de respaldo está siendo usado por otro proceso", "Archivo en Uso",
                                     MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                else
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ExportToFile(file);
                                    conn.Close();
                                }
                            }
                        }
                    }
                    catch
                    {
                        //XD
                    }
                }
            }
        }*/
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
        public List<List<String>> GetFullProductos(string condicion)
        {
            List<List<String>> ProdList = new List<List<string>>();
            try
            {
                String query = "select Codigo,Descripcion,Precio,Stock,PrecioCompra,Instalacion from Productos " + condicion;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Prod = new List<String>();
                                Prod.Add(dr.GetString(0));//cod
                                Prod.Add(dr.GetString(1));//desc
                                Prod.Add(dr.GetInt32(2).ToString());//precio
                                Prod.Add(dr.GetInt32(3).ToString());//stock
                                Prod.Add(dr.GetInt32(4).ToString());//pcompra
                                Prod.Add(dr.GetInt32(5).ToString());//instalacion
                                ProdList.Add(Prod);
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdList;
        }
        public List<String> GetFullProductosStats(string condicion)
        {
            List<String> ProdStats = new List<String>();
            try
            {
                String query = "select SUM(PrecioCompra * Stock) as SumaCompra, SUM(Precio * Stock) as SumaPrecio from Productos " + condicion;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            List<String> Prod = new List<String>();
                            dr.Read();
                            ProdStats.Add(dr.GetInt32(0).ToString("#,##0"));//SUMCompra
                            ProdStats.Add(dr.GetInt32(1).ToString("#,##0"));//SUMVenta
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdStats;
        }
        public bool AddItem(List<String> NuevoItem)
        {
            /*NuevoItem  
             * Codigo = 0
             * Descripcion = 1
             * Stock = 2
             * Precio = 3
             * PrecioCompra = 4
             * Instalacion = 5
             * Familia = 6
             */
            try
            {
                String query = @"insert into Productos(Codigo, Descripcion,Stock,Precio,PrecioCompra,Instalacion,Familia) values"
                                + "(?cod,?desc,?stock,?precio,?preciocompra,?instalacion,?familia)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?cod", MySqlDbType.String).Value = NuevoItem[0];
                        cmd.Parameters.Add("?desc", MySqlDbType.String).Value = NuevoItem[1];
                        cmd.Parameters.Add("?stock", MySqlDbType.Int32).Value = NuevoItem[2];
                        cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = NuevoItem[3];
                        cmd.Parameters.Add("?preciocompra", MySqlDbType.Int32).Value = NuevoItem[4];
                        cmd.Parameters.Add("?instalacion", MySqlDbType.Int32).Value = NuevoItem[5];
                        cmd.Parameters.Add("?familia", MySqlDbType.String).Value = NuevoItem[6];
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error agregando Item. \nRevise sus datos y compruebe que el codigo no esté duplicado\n" + e.ToString(),
                    "Error agregando Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool AddProveedor(List<String> NuevoProveedor)
        {
            /*NuevoProveedor
             * Rut = 0
             * Nombre = 1
             * Direccion = 2
             * Telefono = 3
             * Correo = 4
             */
            try
            {
                String query = @"insert into Proveedores(RUT, Nombre,Desde,Direccion,Telefono,Correo) values"
                                + "(?rut,?nom,?desde,?dir,?tel,?corr)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?rut", MySqlDbType.String).Value = NuevoProveedor[0];
                        cmd.Parameters.Add("?nom", MySqlDbType.String).Value = NuevoProveedor[1];
                        cmd.Parameters.Add("?desde", MySqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("?dir", MySqlDbType.String).Value = NuevoProveedor[2];
                        cmd.Parameters.Add("?tel", MySqlDbType.String).Value = NuevoProveedor[3];
                        cmd.Parameters.Add("?corr", MySqlDbType.String).Value = NuevoProveedor[4];
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error agregando Item. \nRevise sus datos y compruebe que el codigo no esté duplicado\n" + e.ToString(),
                    "Error agregando Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public List<List<String>> getFactura(String ID)
        {
            List<List<String>> DatosVenta = new List<List<String>>();
            try
            {
                string query = "select ID, Fecha, Descripcion, Neto, IVA, Total, RutProveedor, Proveedores.Nombre from Facturas INNER JOIN Proveedores on Proveedores.RUT = Facturas.RutProveedor where Facturas.ID = '" + ID + "' order by ID ASC limit 1";
                //"server=sql10.freemysqlhosting.net; Port=3306; Database=sql10482599; User=sql10482599; Password=yw79UwiafX"
                using (MySqlConnection c = new MySqlConnection(ConnectionString))

                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            List<String> Datos = new List<String>();
                            dr.Read();
                            Datos.Add(dr.GetInt32(0).ToString());//ID
                            Datos.Add(dr.GetDateTime(1).ToString("dd/MM/yyyy"));//Fecha
                            Datos.Add(dr.GetString(2));//Desc
                            Datos.Add("$ " + dr.GetInt32(3).ToString());//Neto
                            Datos.Add("$ " + dr.GetInt32(4).ToString());//IVA
                            Datos.Add("$ " + dr.GetInt32(5).ToString());//Total
                            Datos.Add(dr.GetString(6));//RUT
                            Datos.Add(dr.GetString(7));//Nombre
                            DatosVenta.Add(Datos);
                        }
                    }
                    c.Close();
                }
                query = "select Productos.Descripcion, FacturaProd.PrecioCompra, FacturaProd.Cantidad from Productos INNER JOIN FacturaProd " +
                    "on FacturaProd.CodigoProd = Productos.Codigo where FacturaProd.IDFactura = " + ID;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Items = new List<String>();
                                Items.Add(dr.GetString(0));
                                Items.Add(dr.GetInt32(1).ToString());
                                DatosVenta.Add(Items);
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosVenta;
        }
        public List<List<String>> GetVenta(String ID)
        {
            List<List<String>> DatosVenta = new List<List<String>>();
            try
            {
                string query = "select ID, Fecha, Descripcion, Patente, RUT, Neto, IVA, Total, Descuento,TipoPago from Ventas where ID = '" + ID + "' order by ID ASC limit 1";
                //"server=sql10.freemysqlhosting.net; Port=3306; Database=sql10482599; User=sql10482599; Password=yw79UwiafX"
                using (MySqlConnection c = new MySqlConnection(ConnectionString))

                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            List<String> Datos = new List<String>();
                            dr.Read();
                            Datos.Add(dr.GetInt32(0).ToString());//ID
                            Datos.Add(dr.GetDateTime(1).ToString("dd/MM/yyyy"));//Fecha
                            Datos.Add(dr.GetString(2));//Desc
                            Datos.Add(dr.GetString(3));//Pat
                            Datos.Add(dr.GetString(4));//RUT
                            Datos.Add("$ " + dr.GetInt32(5).ToString());//Neto
                            Datos.Add("$ " + dr.GetInt32(6).ToString());//IVA
                            Datos.Add("$ " + dr.GetInt32(7).ToString());//Total
                            Datos.Add(dr.GetInt32(8).ToString() + "%");//descto
                            Datos.Add(dr.GetString(9));//TipoPago
                            DatosVenta.Add(Datos);
                        }
                    }
                    c.Close();
                }
                query = "select Productos.Descripcion, VentaProd.Precio from Productos INNER JOIN VentaProd " +
                    "on VentaProd.CodigoProducto = Productos.Codigo where VentaProd.IDVenta = " + ID;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Items = new List<String>();
                                Items.Add(dr.GetString(0));
                                Items.Add(dr.GetInt32(1).ToString());
                                DatosVenta.Add(Items);
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosVenta;
        }
        public List<List<String>> GetNota(String ID)
        {
            List<List<String>> DatosNota = new List<List<String>>();
            try
            {
                string query = "select ID, Factura, CFP, Monto, Fecha, Descripcion from NotasCredito where ID = '" + ID + "' order by ID ASC limit 1";
                //"server=sql10.freemysqlhosting.net; Port=3306; Database=sql10482599; User=sql10482599; Password=yw79UwiafX"
                using (MySqlConnection c = new MySqlConnection(ConnectionString))

                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            List<String> Datos = new List<String>();
                            dr.Read();
                            Datos.Add(dr.GetInt32(0).ToString()); //ID
                            Datos.Add(dr.GetString(1)); //Factura
                            Datos.Add(dr.GetString(2)); //CFP
                            Datos.Add("$ " + dr.GetInt32(3).ToString()); //Monto
                            Datos.Add(dr.GetDateTime(4).ToString("dd/MM/yyyy")); //Fecha
                            Datos.Add(dr.GetString(5)); //Descripcion
                            DatosNota.Add(Datos);
                        }
                    }
                    c.Close();
                }
                query = "select Productos.Descripcion, NotasProd.Neto from Productos INNER JOIN NotasProd " +
                    "on NotasProd.CodigoProducto = Productos.Codigo where NotasProd.IDNota = " + ID;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Items = new List<String>();
                                Items.Add(dr.GetString(0));
                                Items.Add(dr.GetInt32(1).ToString());
                                DatosNota.Add(Items);
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosNota;
        }
        public List<String> GetItembySearch(String Search)
        {
            List<String> Resultados = new List<String>();
            try // CHECK EXISTE
            {
                String query = "select Descripcion,Codigo from Productos where Descripcion like '%" + Search +
                    "%'OR Codigo like '%" + Search + "%'";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Resultados.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return Resultados;
        }
        public List<String> GetVehiculo(String Patente)
        {
            List<String> DatosVehiculo = new List<String> { "", "", "" };

            try
            {
                String query = "select Marca,Modelo,Anno from Vehiculos where Patente = '" + Patente +
                    "'order by Patente ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                            {
                                c.Close();
                                return DatosVehiculo;
                            }
                            dr.Read();
                            DatosVehiculo[0] = dr.GetString(0);
                            DatosVehiculo[1] = dr.GetString(1);
                            DatosVehiculo[2] = dr.GetInt32(2).ToString();

                        }
                    }
                    c.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return DatosVehiculo;
        }
        public List<String> GetCliente(String Rut)
        {
            List<String> DatosCliente = new List<String> { "", "", "" };

            try
            {
                String query = "select Nombre,Telefono,Correo from Clientes where RUT = '" + Rut +
                    "'order by RUT ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                            {
                                c.Close();
                                return DatosCliente;
                            }
                            dr.Read();
                            DatosCliente[0] = dr.GetString(0);
                            DatosCliente[1] = dr.GetString(1);
                            DatosCliente[2] = dr.GetString(2);

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return DatosCliente;
        }
        public List<String> GetComunas()
        {
            List<String> ComunasList = new List<string>();
            try
            {
                String query = "select NombreComuna from Comunas";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ComunasList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ComunasList;
        }
        public void NuevoCliente(List<String> DatosCliente)
        {
            //NuevoCliente(Rut,Nombre,Telefono,Correo)
            //check if cliente existe
            //si existe, hacer nada, marcar que cliente existe
            //si no existe, abrir dialog para preguntar por direccion y comuna
            bool existe = false;
            try // CHECK EXISTE
            {
                String query = "select RUT from Clientes where RUT = '" + DatosCliente[0] +
                    "'order by RUT ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            existe = dr.HasRows;
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            if (!existe)
            {
                String Dir = "";
                String Com = "";
                InputDirComuna idc = new InputDirComuna();
                var result = idc.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Dir = idc.Direccion;
                    Com = idc.Comuna;
                }
                try
                {
                    String query = "insert into YyPU5GjIGr.Clientes (RUT,Nombre,Telefono,Correo,Direccion,Comuna) values" +
                                "(?RUT,?nombre,?telefono,?correo,?direccion,?comuna)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = c.CreateCommand())
                        {
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("?RUT", DatosCliente[0]);
                            cmd.Parameters.Add("?nombre", MySqlDbType.String).Value = DatosCliente[1];
                            cmd.Parameters.Add("?telefono", MySqlDbType.String).Value = DatosCliente[2];
                            cmd.Parameters.Add("?correo", MySqlDbType.String).Value = DatosCliente[3];
                            cmd.Parameters.Add("?direccion", MySqlDbType.String).Value = Dir;
                            cmd.Parameters.Add("?comuna", MySqlDbType.String).Value = Com;
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
            }
        }
        public void NuevoVehiculo(List<String> DatosVehiculo)
        {
            //NuevoVehiculo(Patente,Marca,Modelo,Anno)
            //check si existe
            //si vehiculo no existe, registrar
            bool existe = false;
            try // CHECK EXISTE
            {
                String query = "select Patente from Vehiculos where Patente = '" + DatosVehiculo[0] +
                    "'order by Patente ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            existe = dr.HasRows;
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            if (!existe)
            {
                try
                {
                    String query = @"insert into Vehiculos(Patente,Marca,Modelo,Anno) values" +
                                "(?patente,?marca,?modelo,?anno)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?patente", MySqlDbType.String).Value = DatosVehiculo[0];
                            cmd.Parameters.Add("?marca", MySqlDbType.String).Value = DatosVehiculo[1];
                            cmd.Parameters.Add("?modelo", MySqlDbType.String).Value = DatosVehiculo[2];
                            cmd.Parameters.Add("?anno", MySqlDbType.Int32).Value = DatosVehiculo[3];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
            }
        }
        public void IngresarFactura(int ID, List<String> DatosFactura, List<List<String>> Productos, int Total)
        {
            int totalreal = Total;
            int Neto = (totalreal) * 100 / 119;
            int Iva = totalreal - Neto;
            DateTime fecha = DateTime.Now;
            try
            {
                String query = @"insert into Facturas(ID, Fecha, Descripcion, Neto, IVA, Total, RutProveedor, NumeroFactProveedor)"
                                        + " values(?id, ?fecha,?desc,?neto,?iva,?total,?rutprov,?nfp)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = ID;
                        cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosFactura[4];
                        cmd.Parameters.Add("?neto", MySqlDbType.Int32).Value = Neto;
                        cmd.Parameters.Add("?iva", MySqlDbType.Int32).Value = Iva;
                        cmd.Parameters.Add("?total", MySqlDbType.Int32).Value = Total;
                        cmd.Parameters.Add("?rutprov", MySqlDbType.String).Value = DatosFactura[2];
                        cmd.Parameters.Add("?nfp", MySqlDbType.String).Value = DatosFactura[1];
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
                foreach (List<String> codigoprecio in Productos)
                {
                    query = @"insert into FacturaProd(IDFactura, CodigoProd, PrecioCompra, Cantidad) values"
                                + "(?idfact,?codigo,?precio, 1)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?idfact", MySqlDbType.Int32).Value = ID;
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = codigoprecio[1];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                    query = @"UPDATE Productos SET Stock = Stock+1 WHERE Codigo = ?codigo";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public void IngresarNota(int ID, List<String> DatosNota, List<List<String>> Productos, int Neto)
        {
            DateTime fecha = DateTime.Now;
            try
            {
                String query = @"insert into NotasCredito(ID, Factura, CFP, Monto, Fecha, Descripcion)"
                                        + " values(?id,?fact,?cfp,?monto,?fecha,?desc)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = ID;
                        cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosNota[0];
                        cmd.Parameters.Add("?monto", MySqlDbType.Int32).Value = Neto;
                        cmd.Parameters.Add("?fact", MySqlDbType.String).Value = DatosNota[1];
                        cmd.Parameters.Add("?cfp", MySqlDbType.String).Value = DatosNota[2];
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
                foreach (List<String> codigoprecio in Productos)
                {
                    query = @"insert into FacturaProd(IDFactura, CodigoProd, PrecioCompra, Cantidad) values"
                                + "(?idfact,?codigo,?precio, 1)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?idfact", MySqlDbType.Int32).Value = ID;
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = codigoprecio[1];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                    query = @"UPDATE Productos SET Stock = Stock-1 WHERE Codigo = ?codigo";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public void IngresarVenta(List<String> DatosVenta, List<List<String>> Productos, int Total, int ID, String condicion)
        {
            /*
            Datosventa:
            0:TipoPago
            1:Desc
            2:telefono
            3:Patente
            4:Marca
            5:Modelo
            6:correo
            7:descuento
            8:anno
            9:Nombre
            10:Rut
            */
            int totalreal = Total / (1 - (Int32.Parse(DatosVenta[7]) / 100));
            int Neto = (totalreal) * 100 / 119;
            int Iva = totalreal - Neto;
            try
            {

                if (condicion.Equals("normal"))
                {
                    //NuevoCliente(Rut,Nombre,Telefono,Correo)
                    NuevoCliente(new List<String> { DatosVenta[10], DatosVenta[9], DatosVenta[2], DatosVenta[6] });
                    //NuevoVehiculo(Patente,Marca,Modelo,Anno)
                    NuevoVehiculo(new List<String> { DatosVenta[3], DatosVenta[4], DatosVenta[5], DatosVenta[8] });

                    String query = "insert into Ventas(Fecha,Descripcion,Patente,RUT,Neto,Iva,Total,Descuento,TipoPago) "
                                + "values(?fecha,?desc,?patente,?rut,?neto,?iva,?total,?descuento,?tp)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.AddWithValue("?fecha", DateTime.Now);
                            cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosVenta[1];
                            cmd.Parameters.Add("?patente", MySqlDbType.String).Value = DatosVenta[3];
                            cmd.Parameters.Add("?rut", MySqlDbType.String).Value = DatosVenta[10];
                            cmd.Parameters.Add("?neto", MySqlDbType.Int32).Value = Neto;
                            cmd.Parameters.Add("?iva", MySqlDbType.Int32).Value = Iva;
                            cmd.Parameters.Add("?total", MySqlDbType.Int32).Value = Total;
                            cmd.Parameters.Add("?descuento", MySqlDbType.Int32).Value = DatosVenta[7];
                            cmd.Parameters.Add("?tp", MySqlDbType.String).Value = DatosVenta[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                else if (condicion.Equals("sinvehiculo"))
                {
                    String query = @"insert into Ventas(Fecha, Descripcion, Patente, RUT, Neto, Iva, Total, Descuento, TipoPago)"
                                          + " values(?fecha,?desc,?patente,?rut,?neto,?iva,?total,?descuento,?tp)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now;
                            cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosVenta[1];
                            cmd.Parameters.Add("?patente", MySqlDbType.String).Value = "XX-XX-XX";
                            cmd.Parameters.Add("?rut", MySqlDbType.String).Value = DatosVenta[10];
                            cmd.Parameters.Add("?neto", MySqlDbType.Int32).Value = Neto;
                            cmd.Parameters.Add("?iva", MySqlDbType.Int32).Value = Iva;
                            cmd.Parameters.Add("?total", MySqlDbType.Int32).Value = Total;
                            cmd.Parameters.Add("?descuento", MySqlDbType.Int32).Value = DatosVenta[7];
                            cmd.Parameters.Add("?tp", MySqlDbType.String).Value = DatosVenta[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                else if (condicion.Equals("sincliente"))
                {
                    String query = @"insert into Ventas(Fecha, Descripcion, Patente, RUT, Neto, Iva, Total, Descuento, TipoPago)"
                                          + " values(?fecha,?desc,?patente,?rut,?neto,?iva,?total,?descuento,?tp)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now;
                            cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosVenta[1];
                            cmd.Parameters.Add("?patente", MySqlDbType.String).Value = DatosVenta[3];
                            cmd.Parameters.Add("?rut", MySqlDbType.String).Value = "XXXXXXXX-X";
                            cmd.Parameters.Add("?neto", MySqlDbType.Int32).Value = Neto;
                            cmd.Parameters.Add("?iva", MySqlDbType.Int32).Value = Iva;
                            cmd.Parameters.Add("?total", MySqlDbType.Int32).Value = Total;
                            cmd.Parameters.Add("?descuento", MySqlDbType.Int32).Value = DatosVenta[7];
                            cmd.Parameters.Add("?tp", MySqlDbType.String).Value = DatosVenta[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                foreach (List<String> codigoprecio in Productos)
                {
                    String query = @"insert into VentaProd(IDVenta, CodigoProducto, Precio) values"
                                + "(?idventa,?codigo,?precio)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?idventa", MySqlDbType.Int32).Value = ID;
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = codigoprecio[1];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                    query = "UPDATE Productos SET Stock = Stock-1 WHERE Codigo = ?codigo";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public void IngresarDevolucion(List<String> DatosDevolucion, List<List<String>> Productos1, List<List<String>> Productos2, int Total1, int Total2)
        {
            /*
             * DatosDevolucion
             * 0: ID
             * 1: IDV
             * 2: Desc
             */
            try
            {
                String query = "insert into Devoluciones(ID,VentaID,Detalles,Fecha,Total1,Total2) "
                                + "values(?id,?idv,?desc,?fecha,?t1,?t2)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?id", MySqlDbType.String).Value = DatosDevolucion[0];
                        cmd.Parameters.Add("?idv", MySqlDbType.String).Value = DatosDevolucion[1];
                        cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosDevolucion[2];
                        cmd.Parameters.AddWithValue("?fecha", DateTime.Now);
                        cmd.Parameters.Add("?t1", MySqlDbType.Int32).Value = Total1;
                        cmd.Parameters.Add("?t2", MySqlDbType.Int32).Value = Total2;
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
                foreach (List<String> codigoprecio in Productos1)
                {
                    query = @"insert into DevolucionesProd(IDDevolucion, Codigo, Precio, Tipo) values"
                                + "(?id,?cod,?precio,?tipo)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = DatosDevolucion[0];
                            cmd.Parameters.Add("?cod", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = codigoprecio[1];
                            cmd.Parameters.Add("?tipo", MySqlDbType.Int32).Value = 1;
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                    query = "UPDATE Productos SET Stock = Stock+1 WHERE Codigo = ?codigo";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
                foreach (List<String> codigoprecio in Productos2)
                {
                    query = @"insert into DevolucionesProd(IDDevolucion, Codigo, Precio, Tipo) values"
                                + "(?id,?cod,?precio,?tipo)";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = DatosDevolucion[0];
                            cmd.Parameters.Add("?cod", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.Parameters.Add("?precio", MySqlDbType.Int32).Value = codigoprecio[1];
                            cmd.Parameters.Add("?tipo", MySqlDbType.Int32).Value = -1;
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                    query = "UPDATE Productos SET Stock = Stock-1 WHERE Codigo = ?codigo";
                    using (MySqlConnection c = new MySqlConnection(ConnectionString))
                    {
                        c.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, c))
                        {
                            cmd.Parameters.Add("?codigo", MySqlDbType.String).Value = codigoprecio[0];
                            cmd.ExecuteNonQuery();
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public List<String> GetItem(String NombreProd)
        {
            List<String> NewProd = new List<string>();
            try
            {
                String query = "select Codigo,Descripcion,Precio,Instalacion,PrecioCompra from Productos where Descripcion = '" + NombreProd + "' or Codigo = '" + NombreProd + "'" +
                    "order by Codigo ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NewProd.Add(dr.GetString(0));
                            NewProd.Add(dr.GetString(1));
                            NewProd.Add(dr.GetInt32(2).ToString());
                            NewProd.Add(dr.GetInt32(3).ToString());
                            NewProd.Add(dr.GetInt32(4).ToString());
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Item '" + NombreProd + "' no encontrado \n Error: " + e.GetType().ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return NewProd;
        }
        public List<String> GetDatosProveedor(String NombreProv)
        {
            List<String> DatosProveedor = new List<string>();
            try
            {
                String query = "select Rut,Telefono,Correo from Proveedores where Nombre = '" + NombreProv + "'" +
                    "order by Nombre ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            DatosProveedor.Add(dr.GetString(0));
                            DatosProveedor.Add(dr.GetString(1));
                            DatosProveedor.Add(dr.GetString(2));
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Proveedor '" + NombreProv + "' no encontrado \n Error: " + e.GetType().ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosProveedor;
        }
        public List<String> GetDatosFactura(String DescFactura)
        {
            List<String> DatosFactura = new List<string>();
            try
            {
                String query = "select NumeroFactProveedor, Fecha from Facturas where Descripcion = '" + DescFactura + "'" +
                    "order by Descripcion ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            DatosFactura.Add(dr.GetString(0));
                            DatosFactura.Add(dr.GetDateTime(1).ToShortDateString());
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Factura '" + DescFactura + "' no encontrado \n Error: " + e.GetType().ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosFactura;
        }
        public List<String> GetDatosVenta(String DescVenta)
        {
            List<String> DatosVenta = new List<string>();
            try
            {
                String query = "select ID, Fecha from Ventas where Descripcion = '" + DescVenta + "'" +
                    "order by Descripcion ASC limit 1";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            DatosVenta.Add(dr.GetString(0));
                            DatosVenta.Add(dr.GetString(1));
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Venta '" + DescVenta + "' no encontrado \n Error: " + e.GetType().ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return DatosVenta;
        }
        public List<String> GetProductos()
        {
            List<String> ProdList = new List<string>();
            try
            {
                String query = "select Descripcion from Productos";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProdList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdList;
        }
        public List<String> GetProveedores()
        {
            List<String> ProdList = new List<string>();
            try
            {
                String query = "select Nombre from Proveedores";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProdList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdList;
        }
        public List<String> GetFacturas()
        {
            List<String> ProdList = new List<string>();
            try
            {
                String query = "select Descripcion from Facturas";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProdList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdList;
        }
        public List<String> GetVentas()
        {
            List<String> ProdList = new List<string>();
            try
            {
                String query = "select Descripcion from Ventas";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProdList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ProdList;
        }
        public List<String> GetMarcas()
        {
            List<String> MarcasList = new List<string>();
            try
            {
                String query = "select DISTINCT(Marca) from VehiculosDB";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            MarcasList.Add("Marca no Listada");
                            while (dr.Read())
                            {
                                MarcasList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return MarcasList;
        }
        public List<String> GetModelobyMarca(String Marca)
        {
            List<String> ModelosList = new List<string>();
            try
            {
                String query = "select Modelo from VehiculosDB where Marca = '" + Marca + "'";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.HasRows)
                            {
                                return new List<String> { "" };
                            }
                            while (dr.Read())
                            {
                                ModelosList.Add(dr.GetString(0));
                            }
                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return ModelosList;
        }
        public String GetNextVentaID()
        {
            String NextVentaID = "";
            try
            {
                String query = "select MAX(ID) from Ventas";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NextVentaID = (dr.GetInt32(0) + 1).ToString();

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return NextVentaID;
        }
        public String GetNextDevolucionID()
        {
            String NextDevolucionID = "";
            try
            {
                String query = "select MAX(ID) from Devoluciones";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NextDevolucionID = (dr.GetInt32(0) + 1).ToString();

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return NextDevolucionID;
        }
        public String GetNextFacturaID()
        {
            String NextVentaID = "";
            try
            {
                String query = "select MAX(ID) from Facturas";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NextVentaID = (dr.GetInt32(0) + 1).ToString();

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return NextVentaID;
        }
        public String GetNextNotaID()
        {
            String NextVentaID = "";
            try
            {
                String query = "select MAX(ID) from NotasCredito";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NextVentaID = (dr.GetInt32(0) + 1).ToString();

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return NextVentaID;
        }
        public List<List<String>> ConsultaPatente(String Search, String extrastring = "")
        {
            List<List<String>> Servicios = new List<List<String>>();
            try
            {
                String query = "select ID, Fecha, Descripcion, Patente, RUT, Neto, IVA, Total, Descuento, TipoPago from Ventas" + Search + extrastring;
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Servicio = new List<String>(new string[]
                                {
                                    dr.GetInt32(0).ToString(), //ID
                                    dr.GetDateTime(1).ToString("dd/MM/yyyy"), //Fecha
                                    dr.GetString(2), //Desc
                                    dr.GetString(3), //Patente
                                    dr.GetString(4), //RUT
                                    "$ " + dr.GetInt32(5).ToString(), //Neto
                                    "$ " + dr.GetInt32(6).ToString(), //Iva
                                    "$ " + dr.GetInt32(7).ToString(), //Total
                                    dr.GetInt32(8).ToString()+"%", //Descuento
                                    dr.GetString(9),//TipoPago
                            });
                                Servicios.Add(Servicio);

                            }
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return Servicios;
        }
        public List<List<String>> ConsultaNotas()
        {
            List<List<String>> Notas = new List<List<String>>();
            try
            {
                String query = "select ID, Factura, CFP, Monto, Fecha, Descripcion from NotasCredito where ID >0";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Nota = new List<String>(new string[]
                                {
                                    dr.GetInt32(0).ToString(), //ID
                                    dr.GetString(1), //Factura
                                    dr.GetString(2), //CFP
                                    "$ " + dr.GetInt32(3).ToString(), //Monto
                                    dr.GetDateTime(4).ToString("dd/MM/yyyy"), //Fecha
                                    dr.GetString(5), //Descripcion
                            });
                                Notas.Add(Nota);

                            }
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return Notas;
        }
        public List<List<String>> ConsultaFacturas()
        {
            List<List<String>> Facturas = new List<List<String>>();
            try
            {
                String query = "select ID, NumeroFactProveedor, Proveedores.Nombre, Fecha, Descripcion, Neto, IVA, Total from Facturas INNER JOIN Proveedores on Proveedores.RUT = Facturas.RutProveedor";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Factura = new List<String>(new string[]
                                {
                                    dr.GetInt32(0).ToString(), //ID
                                    dr.GetString(1), //NFP
                                    dr.GetString(2), //NombreProveedor
                                    dr.GetDateTime(3).ToString("dd/MM/yyyy"), //Fecha
                                    dr.GetString(4), //Desc
                                    "$ " + dr.GetInt32(5).ToString(), //Neto
                                    "$ " + dr.GetInt32(6).ToString(), //IVA
                                    "$ " + dr.GetInt32(7).ToString(), //Total
                            });
                                Facturas.Add(Factura);

                            }
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return Facturas;
        }
        public String GetNextIngresoID()
        {
            String NextVentaID = "";
            try
            {
                String query = "select MAX(ID) from RegistroIngresos";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            dr.Read();
                            NextVentaID = (dr.GetInt32(0) + 1).ToString();

                        }
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return NextVentaID;
        }
        public void RegistrarIngreso(int ID, List<String> DatosIngreso)
        {
            //DatosIngreso
            //0:patente
            //1:marca
            //2:modelo
            //3:color
            //4:nombre
            //5:telefono
            //6:desc
            //7:pronost
            DateTime fecha = DateTime.Now;
            try
            {
                String query = @"insert into RegistroIngresos(ID, Fecha, Patente, Marca, Modelo, Color, Nombre, Telefono, Descripcion, Pronostico)"
                                        + " values(?id,?fecha,?pat,?marca,?mod,?col,?nom,?tel,?desc,?pron)";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = ID;
                        cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("?pat", MySqlDbType.String).Value = DatosIngreso[0];
                        cmd.Parameters.Add("?marca", MySqlDbType.String).Value = DatosIngreso[1];
                        cmd.Parameters.Add("?mod", MySqlDbType.String).Value = DatosIngreso[2];
                        cmd.Parameters.Add("?col", MySqlDbType.String).Value = DatosIngreso[3];
                        cmd.Parameters.Add("?nom", MySqlDbType.String).Value = DatosIngreso[4];
                        cmd.Parameters.Add("?tel", MySqlDbType.String).Value = DatosIngreso[5];
                        cmd.Parameters.Add("?desc", MySqlDbType.String).Value = DatosIngreso[6];
                        cmd.Parameters.Add("?pron", MySqlDbType.String).Value = DatosIngreso[7];
                        cmd.ExecuteNonQuery();
                    }
                    c.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        public List<List<String>> GetRegistros()
        {
            List<List<String>> Ingresos = new List<List<String>>();
            try
            {
                String query = "select ID, Fecha, Patente, Marca, Modelo, Color, Nombre, Telefono, Descripcion, Pronostico from RegistroIngresos where ID>0";
                using (MySqlConnection c = new MySqlConnection(ConnectionString))
                {
                    c.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, c))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                List<String> Ingreso = new List<String>(new string[]
                                {
                                    dr.GetInt32(0).ToString(), //ID
                                    dr.GetDateTime(1).ToString("dd/MM/yyyy"), //Fecha
                                    dr.GetString(2), //Patente
                                    dr.GetString(3), //Marca
                                    dr.GetString(4), //Modelo
                                    dr.GetString(5), //Color
                                    dr.GetString(6), //Nombre
                                    dr.GetString(7), //Telefono
                                    dr.GetString(8), //Descripcion
                                    dr.GetString(9),//Pronostico
                            });
                                Ingresos.Add(Ingreso);

                            }
                        }
                        c.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            return Ingresos;
        }
        static bool CheckConn()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
