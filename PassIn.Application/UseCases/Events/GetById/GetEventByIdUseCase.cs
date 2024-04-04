using PassIn.Communication.Responses;
using PassIn.Exceptions;
using PassIn.Infrastructure;

namespace PassIn.Application.UseCases.Events.GetById
{
    public class GetEventByIdUseCase
    {
        public ResponseEventJson Execute(Guid id)
        {

            var dbContext = new PassInDBContext();
            var entity = dbContext.Events.Find(id);

            if(entity is null) throw new NotFoundException("ERROR: Can't find an event with this id.");


            return new ResponseEventJson
            {
                Id = entity.Id,
                Title = entity.Title,
                Details = entity.Details,
                MaximumAttendees = entity.Maximum_Attendees,
                AttendeesAmount = -1
            };

        }

    }
}
