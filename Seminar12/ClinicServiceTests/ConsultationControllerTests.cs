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
    public class ConsultationControllerTests
    {
        private ConsultationController _consultController;
        private Mock<IConsultationRepository> _mockConsultRepository;

        public ConsultationControllerTests()
        {
            _mockConsultRepository = new Mock<IConsultationRepository>();
            _consultController = new ConsultationController(_mockConsultRepository.Object);

        }

        [Fact]
        public void ConsultationUpdateTest()
        {
            // МЕТОД ТЕСТИРОВАНИЯ СОСТОИТ ИЗ УСЛОВНЫХ 3 ЧАСТЕЙ

            // [1] Подготовка данных для тестирования
            UpdateConsultRequest updateConsultRequest = new UpdateConsultRequest();
            updateConsultRequest.ConsultationId = 2;
            updateConsultRequest.ClientId = 1;
            updateConsultRequest.PetId = 1;
            updateConsultRequest.ConsultationDate = DateTime.Now.AddDays(-3);
            updateConsultRequest.Description = "Descript";


            // [2] Исполнение тестируемого метода
            ActionResult<int> operationResult = _consultController.Update(updateConsultRequest);

            // [3] Подготовка эталонного результата (expected), проверка результата
            int expectedOperationValue = 1;


            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.Equal<int>(expectedOperationValue, (int)((OkObjectResult)operationResult.Result).Value);

        }
    }
}
