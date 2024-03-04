namespace DemoMvc.Models;
public class HeThongPhanPhoi{
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }
    public ICollection<DaiLy>? DaiLy { get; set; }
}