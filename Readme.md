 🚀 Teknofest 2025 Roket Yarışması - Bozok Roket Takımı Yer İstasyonu Yazılımı

 BOZOK ROKET TAKIMI 2025 TEKNOFEST ROKET TAKIMI TÜRKİYE BİRİNCİSİ

 Proje Adı: BOZOK ROKET YER İSTASYONU

Bu repo, BOZOK ROKET TAKIMI tarafından 2025 Teknofest Roket Yarışması için geliştirilmiş olan, roket ve faydalı yükten gelen telemetri verilerini gerçek zamanlı olarak izlemek ve görselleştirmek amacıyla tasarlanmış kapsamlı bir yer istasyonu yazılımını içermektedir.
* 2025 Teknofest Roket yarışmasında kullanılmış olup başarılı bir şekilde çalışmıştır. 

Yazılım, güvenilir ve performanslı bir takip deneyimi sunmak üzere C# dili ve Windows Forms arayüzü ile geliştirilmiştir.

---

## 🌟 Temel Özellikler

Bu yazılım, roketin ve görev yükü aviyonik sistemlerinden görev sırasında gelen verilerin anlık takibini sağlamak için üç ana sütun üzerine inşa edilmiştir: 
Harita Takibi, 3D Modelleme ve Gerçek Zamanlı Telemetri.:

-Telemetri ve Haberleşme
Seri Port (COM) Haberleşmesi: Roket/Faydalı Yükten gelen verilerin seri port (SerialPort) üzerinden alınması ve işlenmesi.

-2D Coğrafi Takip (GMap.NET Entegrasyonu)
Çift Nokta Takibi: Roket (rocketMarker) ve Faydalı Yük (payloadMarker) konumlarını harita üzerinde eş zamanlı olarak ayrı ayrı işaretleme.
Hareket Takip Modu: Kullanıcı isteğine bağlı olarak haritanın roketi otomatik olarak takip etme (Follow Mode) özelliği.

-3D Uçuş Modellemesi (OpenTK / OpenGL)
Roketin anlık oryantasyonunu (konum ve açısını) temsil eden bir 3D modelin gerçek zamanlı olarak görselleştirilmesi.
Kullanıcı dostu kamera kontrolü: Fare ile modelin döndürülmesi (Rotasyon) ve yakınlaştırılıp/uzaklaştırılması (Zoom) yeteneği.

-Hakem Yer İstasyonu Bağlantısı
 SerialPort üzerinden Port, Baud Rate, Takım ID seçilerek bağlanılması ve Paket sayacı ile Checksum entegrasyonu. 

Kategori              Teknoloji /Kütüphane,                       Amaç
Geliştirme Dili      C#                               Projenin ana dili.
Arayüz               Windows Forms (WinForms)         Kullanıcı dostu ve kararlı grafik arayüzü.
Harita               GMap.NET                         2D uydu/yol haritası üzerinde coğrafi takip.
3D Grafik            OpenTK / OpenGL                  Roketin 3D modelinin gerçek zamanlı gösterimi.
Haberleşme           System.IO.Ports                  Roketle seri (LoRa/RF) iletişim kurma.
.NET Sürümü         .NET Framework 4.7.2              Uygulamanın temelini oluşturan platform.

⚙️ Kurulum ve Çalıştırma
Gereksinimler
.NET Framework 4.7.2 kurulu olmalıdır.

Kullanılan Geliştirme Ortamı: Visual Studio 2022.

Projenin Açılması
Bu depoyu yerel bilgisayarınıza klonlayın:

Bash

git clone https://github.com/Furkan1DEV/2025-TEKNOFEST-BOZOK-ROKET-TAKIMI-YER-STASYONU.git

Proje dosyasını (.sln uzantılı) Visual Studio ile açın.

NuGet paketlerini geri yükleyin (Restore) ve çözümü derleyin (Build).

Uygulamayı çalıştırın ve seri port ayarlarını (COM Port, Baud Rate) roket sistemi ile eşleşecek şekilde yapılandırın.
<p align="center">
  <img src= alt=https://github.com/Furkan1DEV/2025-TEKNOFEST-BOZOK-ROKET-TAKIMI-YER-STASYONU/blob/main/yer_istasyonu_arayuzu.png?raw=true "Yer İstasyonu Arayüzü" width="700"/>
</p>
