//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pavlyuchenko
{
    using System;
    using System.Collections.Generic;
    
    public partial class Маршруты
    {
        public int КодМаршрута { get; set; }
        public int Заказ { get; set; }
        public int Транспорт { get; set; }
        public int НомерЭтапа { get; set; }
        public string НачальныйАдрес { get; set; }
        public string КонечныйАдрес { get; set; }
        public bool Выполнено { get; set; }
    
        public virtual Заказы Заказы { get; set; }
        public virtual Транспорты Транспорты { get; set; }
    }
}
