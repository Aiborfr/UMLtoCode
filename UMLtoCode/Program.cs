using System;

namespace UMLtoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto de la clase Customer
            Customer customer = new Customer(1, "Juan Pérez", "123456789", "juanperez@gmail.com", DateTime.Now, 800);

            // Creamos un objeto de la clase Address
            Address address = new Address("Calle 123", "Ciudad de México", "CDMX", 12345, "México");
            customer.Address = address;

            // Creamos un objeto de la clase Savings
            Savings savings = new Savings("ES123456789", 1000, customer, 200);

            // Realizamos una transacción en la cuenta de ahorros
            savings.Transaction("Compra en línea", 150);

            // Liberamos algunos ahorros protegidos en la cuenta de ahorros
            savings.LiberateSavings(100);

            // Creamos un objeto de la clase Employee
            Employee employee = new Employee(2, "María García", "987654321", "mariagarcia@gmail.com", "IT", 2000);

            // Imprimimos información sobre el cliente y la cuenta de ahorros
            Console.WriteLine("Información del cliente:");
            Console.WriteLine("Nombre: " + customer.Name);
            Console.WriteLine("Email: " + customer.Email);
            Console.WriteLine("Dirección: " + customer.Address.ToString());
            Console.WriteLine("Puntuación crediticia: " + customer.CreditScore);

            Console.WriteLine("Información de la cuenta de ahorros:");
            Console.WriteLine("IBAN: " + savings.IBAN);
            Console.WriteLine("Saldo: " + savings.Amount);
            Console.WriteLine("Cantidad de ahorros protegidos: " + savings.ProtectedAmount);

            // Imprimimos información sobre el empleado
            Console.WriteLine("Información del empleado:");
            Console.WriteLine("Nombre: " + employee.Name);
            Console.WriteLine("Email: " + employee.Email);
            Console.WriteLine("Departamento: " + employee.Department);
            Console.WriteLine("Salario: " + employee.Salary);

            // Esperamos a que el usuario presione una tecla para cerrar la aplicación
            Console.ReadKey();
        }
    }

}
