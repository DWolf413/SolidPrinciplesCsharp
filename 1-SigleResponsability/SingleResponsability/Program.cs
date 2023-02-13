using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper.ExportCSV(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");
