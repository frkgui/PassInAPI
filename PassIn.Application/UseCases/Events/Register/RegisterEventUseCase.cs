using PassIn.Communication.Requests;

namespace PassIn.Application.UseCases.Events.Register
{
    public class RegisterEventUseCase
    {

        public void Execute(RequestEventJson request)
        {
            Validate(request);
        }

        private void Validate(RequestEventJson request)
        {
            if (request.MaximumAttendees <= 0)
            {
                throw new ArgumentException("ERROR: The maximum attendees number is invalid.");
            }

            if (string.IsNullOrWhiteSpace(request.Title))
            {
                throw new ArgumentException("ERROR: Title is invalid or empty.");
            }
        }

    }
}
