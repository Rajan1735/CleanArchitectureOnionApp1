using Domain1;
using MediatR;
using OnionApp1.Service.Students;

namespace Application.CQRS.Commands
{
    public class CreateStudentCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Standard { get; set; }
        public int Rank { get; set; }
        public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
        {
            private readonly IStudentService _studentService;
            public CreateStudentCommandHandler(IStudentService studentService)
            {
                _studentService = studentService;
            }
            public async Task<int> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
            {
             
                return await _studentService.Save(new Domain1.Dtos.StudentDto { Name=command.Name, Standard=command.Standard, Rank=command.Rank});  
            }
        }
    }
}