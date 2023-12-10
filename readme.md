# Calendar Application

Bu proje, kullanıcıların takvim fonksiyonlarına erişim sağlayan bir uygulamayı içerir. Kullanıcılar giriş yaparak takvimdeki günleri 
görüntüleyebilir ve belirli bir güne tıklayarak o güne ilişkin etkinlikleri yönetebilirler.

## Giriş Formu (LOGIN)

Giriş formu, kullanıcının uygulamaya erişim sağlamasını sağlar.

## Join Formu (Form3)

Join formu, kullanıcının uygulamaya erişim sağlamasını sağlar.

## Takvim Formu (Form2)

Takvim formu, kullanıcının takvim görünümünü yönetir. Kullanıcılar takvimde ileri ve geri gitmek, 
günleri görüntülemek ve etkinlik eklemek için bu formu kullanabilirler.

## Gün User Control (UserControlDAYS)

Gün user control, takvimdeki her günü temsil eder ve üzerine tıklanıldığında bir etkinlik penceresini açar.

## Etkinlik Formu (Event)

Etkinlik formu, kullanıcının belirli bir güne tıklayarak eklediği etkinlikleri yönetmesini sağlar.

```csharp
namespace PROJECT1
{
    public partial class LOGIN : Form
    {
        // Giriş formu kodları...
        
    }
    public partial class Form3 : Form
    {
        // Join formu kodları...
        
    }
    public partial class Form2 : Form
    {
    // Takvim formu kodları...
    }

    public partial class UserControlDAYS : UserControl
    {
    // Gün user control kodları...
    }

    public partial class Event : Form
    {
    // Etkinlik formu kodları...
    }
}
