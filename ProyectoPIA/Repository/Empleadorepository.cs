using Microsoft.Data.SqlClient;
using ProyectoPIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPIA.Repository
{
    public class Empleadorepository
    {
        private readonly string connectionString = "Data Source=DESKTOP-KQDG41G\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True;Trust Server Certificate=True";

        public List<Empleado> getempleados()
        {
            var empleados= new List<Empleado>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Empleados ORDER BY Nombre DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado empleado1 = new Empleado();
                                empleado1.name = reader.GetString(0);
                                empleado1.edad = reader.GetInt32(1);
                                empleado1.celular = reader.GetInt32(2);
                                empleado1.carrera = reader.GetString(3);
                                empleado1.id = reader.GetInt32(4);

                                empleados.Add(empleado1);
                            }
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return empleados;
        }

        public Empleado? getempleado(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Empleados WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Empleado empleado1 = new Empleado();
                                empleado1.name = reader.GetString(0);
                                empleado1.edad = reader.GetInt32(1);
                                empleado1.celular = reader.GetInt32(2);
                                empleado1.carrera = reader.GetString(3);

                                return empleado1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
        
        public void CreateEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Empleados" + "(Nombre,Edad, Celular, Carrera, ID) VALUES" + "(@Nombre,@Edad, @Celular, @Carrera, @ID);";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", empleado.name);
                        cmd.Parameters.AddWithValue("@Edad", empleado.edad);
                        cmd.Parameters.AddWithValue("@Celular", empleado.celular);
                        cmd.Parameters.AddWithValue("@Carrera", empleado.carrera);
                        cmd.Parameters.AddWithValue("@ID", empleado.id);

                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Empleados " + "SET Nombre=@Nombre, Edad=@Edad, Celular=@Celular, Carrera=@Carrera " + "WHERE ID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", empleado.name);
                        cmd.Parameters.AddWithValue("@Edad", empleado.edad);
                        cmd.Parameters.AddWithValue("@Celular", empleado.celular);
                        cmd.Parameters.AddWithValue("@Carrera", empleado.carrera);
                        cmd.Parameters.AddWithValue("@ID", empleado.id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public void Deleteempleado(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM Empleados WHERE ID=@ID";
                    using(SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
