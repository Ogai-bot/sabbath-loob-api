using System;
namespace SabbathLoop.Domain.Util
{
	public class ReturnData
	{
        public int Rows { get; set; }
		public EErrorCode ErrorCode { get; set; }
		public string? ErrorMesange { get; set; }
		public dynamic? ResultData { get; set; }
		public DateTimeOffset? BeginDate { get; set; }
		public DateTimeOffset? EndDate { get; set; }

        protected ReturnData() { }
        public ReturnData(int rows, EErrorCode errorCode, string? errorMesange, dynamic? resultData): this()
        {
            Rows = rows;
            ErrorCode = errorCode;
            ErrorMesange = errorMesange;
            ResultData = resultData;
        }
        public ReturnData(int rows, dynamic? resultData) : this(rows, EErrorCode.None, null, resultData as object) { }
        public ReturnData(int rows) : this(rows, EErrorCode.None, null, null) { }
        public ReturnData(EErrorCode errorCode, string? errorMesange) : this(0, errorCode, null, errorMesange) { }

        public ReturnData FinalizeTransition(DateTimeOffset beginDate)
        {
            BeginDate = beginDate;
            EndDate = DateTimeOffset.UtcNow;
            return this;
        }
    }

    public enum EErrorCode
	{
		None = 0,
        OnlySysAdminAccess = 1,
        NotFound = 2,
        InvalidParameters = 3,
        NotAllowedCommand = 4,
        Unauthorized = 5,
        DuplicateUniqueIdentifier = 6,
    }
}

