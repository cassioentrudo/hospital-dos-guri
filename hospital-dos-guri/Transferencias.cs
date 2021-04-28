namespace hospital_dos_guri
{
    public class Transferencias
    {
        public long ID_Transferencia { get; set; }
        public long ID_Hospital_Origem { get; set; }
        public long ID_Hospital_Destino { get; set; }
        public long UTI_Adulto { get; set; }
        public long UTI_Neonatal { get; set; }
        public long UTI_Pediatrica { get; set; }
        public long Emergencia { get; set; }
        public string Status { get; set; }
    }
}
