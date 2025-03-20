namespace HallOfFame.Application.Dtos.Responces
{
    public class SuccessEmptyResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }

        public SuccessEmptyResponse(string message, int statusCode) {
            Message = message;
            StatusCode = statusCode;
        }
    }
}