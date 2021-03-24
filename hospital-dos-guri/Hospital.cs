namespace hospital_dos_guri
{
    public class Hospital
    {
        public long id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public long UTI_Adulto { get; set; }
        public long UTI_Neonatal { get; set; }
        public long UTI_Pediatrica { get; set; }
        public long Emergencia { get; set; }
    }
}
