namespace HallOfFame.Application.Dtos.Responces
{
    public class SuccessResponse<TResponse> where TResponse : class
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public TResponse Data { get; set; }

        public SuccessResponse(string message, int statusCode, TResponse data) {
            Message = message;
            StatusCode = statusCode;
            Data = data;
        }
    }
}