


using desafiohospedagem.models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Arthur", "Floro");
Pessoa p2 = new Pessoa("Maria", "Luiza");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 25.00M);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C")}");