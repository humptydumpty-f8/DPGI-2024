//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp39
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACC_TRANSACTION
    {
        public decimal TXN_ID { get; set; }
        public double AMOUNT { get; set; }
        public System.DateTime FUNDS_AVAIL_DATE { get; set; }
        public System.DateTime TXN_DATE { get; set; }
        public string TXN_TYPE_CD { get; set; }
        public Nullable<int> ACCOUNT_ID { get; set; }
        public Nullable<int> EXECUTION_BRANCH_ID { get; set; }
        public Nullable<int> TELLER_EMP_ID { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual BRANCH BRANCH { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
