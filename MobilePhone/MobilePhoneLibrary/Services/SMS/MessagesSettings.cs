using System;

namespace MobilePhoneLibrary.Services.SMS {
    public class MessagesSettings {
        public int FormatNumber { get; }
        public object ContactSelected { get; }
        public string TextSearch { get; }
        public bool IsFrom { get; }
        public DateTime FromDate { get; }
        public bool IsTo { get; }
        public DateTime ToDate { get; }
        public bool AndCombined { get; }

        public MessagesSettings(int formatNumber, object contactSelected, string textSearch, bool isFrom, DateTime fromDate, bool isTo, DateTime toDate, bool andCombined) {
            FormatNumber = formatNumber;
            ContactSelected = contactSelected;
            TextSearch = textSearch;
            FromDate = fromDate;
            ToDate = toDate;
            IsTo = isTo;
            IsFrom = isFrom;
            AndCombined = andCombined;
        }
    }
}
