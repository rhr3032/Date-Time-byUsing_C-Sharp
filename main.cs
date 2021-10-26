DateTime dateInicio = DateTime.parse(25/10/2021 02:07:13);
DateTime dateFim = DateTime.parse(25/10/2021 05:10:33);

TimeSpan duracao = dateFim - dateInicio;
TimeSpan duracao2 = dateFim.Subtract(dateInicio);

console.WriteLine(duracao);
console.WriteLine(duracao2);