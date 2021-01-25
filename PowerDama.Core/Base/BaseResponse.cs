namespace PowerDama.Core.Base
{
    public class BaseResponse <T> : BaseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        public T Value { get; set; }
    }
}
