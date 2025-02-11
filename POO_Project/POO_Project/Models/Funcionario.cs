namespace Models
{
    /// <summary>
    /// Representa um funcionário no sistema.
    /// </summary>
    public class Employee : Pessoa
    {
        /// <summary>
        /// Número de identificação do funcionário.
        /// </summary>
        public string EmployeeNumber { get; set; }

        /// <summary>
        /// Construtor da classe Employee.
        /// </summary>
        /// <param name="name">Nome do funcionário.</param>
        /// <param name="employeeNumber">Número de identificação do funcionário.</param>
        /// <param name="password">Password do funcionário.</param>
        public Employee(string name, string employeeNumber, string password)
            : base(name, password)
        {
            EmployeeNumber = employeeNumber;
        }

        /// <summary>
        /// Retorna uma representação textual do funcionário.
        /// </summary>
        /// <returns>Uma string que contem informações principais do funcionário.</returns>
        public override string ToString()
        {
            return $"{base.ToString()}, ID: {EmployeeNumber}";
        }
    }
}
