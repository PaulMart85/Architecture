using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ClientControllerTests
    {

        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public ClientControllerTests()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);

        }

        [Fact]
        public void ClientCreateTest()
        {
            // МЕТОД ТЕСТИРОВАНИЯ СОСТОИТ ИЗ УСЛОВНЫХ 3 ЧАСТЕЙ

            // [1] Подготовка данных для тестирования
            CreateClientRequest createClientRequest = new CreateClientRequest();
            createClientRequest.Document = "Pass";
            createClientRequest.SurName = "Surname";
            createClientRequest.FirstName = "Name";
            createClientRequest.Patronymic = "Patro";
            createClientRequest.Birthday = DateTime.Now.AddYears(-35);

            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _clientController.Create(createClientRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;


            Assert.IsType<OkObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);

        }

        [Theory]
        [InlineData(null, "sur", "nam")]
        [InlineData("doc", null, "nam")]
        [InlineData("doc", "sur", null)]
        [InlineData("doc", "", "nam")]
        public void ClientCreateBadRequestTest(string docum, string surn, string firstn)
        {
            CreateClientRequest createClientRequest = new CreateClientRequest();
            createClientRequest.Document = docum;
            createClientRequest.SurName = surn;
            createClientRequest.FirstName = firstn;
            createClientRequest.Patronymic = "Patro";
            createClientRequest.Birthday = DateTime.Now.AddYears(-35);

            ActionResult<int> operationResult = _clientController.Create(createClientRequest);

            int expectedOperationValue = 0;

            Assert.IsType<BadRequestObjectResult>(operationResult.Result);
            Assert.Equal<int>(expectedOperationValue, (int)((BadRequestObjectResult)operationResult.Result).Value);
        }

        [Fact]
        public void GetAllClientsTest()
        {
            // [1] Подготовка данных для тестирования
            _mockClientRepository.Setup(repository =>
                repository.GetAll()).Returns(new List<Client>()
                {
                    new Client(),
                    new Client(),
                    new Client()
                });

            ActionResult<IList<Client>> operationResult = _clientController.GetAll();


            Assert.IsType<OkObjectResult>(operationResult.Result);

            _mockClientRepository.Verify(repository => repository.GetAll(), Times.Once);

            Assert.IsAssignableFrom<IList<Client>>(((OkObjectResult)operationResult.Result).Value);

        }




    }
}
