using Xunit;
using MediChain.Module7.Services;

namespace MediChain.Module7.Tests
{
    public class MedicalApprovalServiceTests
    {
        private readonly MedicalApprovalService _service = new MedicalApprovalService();

        [Fact]
        public void ApproveResult_WhenStatusIsReady_ShouldReturnApprovedAndLocked()
        {
            string result = _service.ApproveResult("Ready_for_Approval", true);
            Assert.Equal("Approved_and_Locked", result); // التحقق من نجاح الاعتماد
        }

        [Fact]
        public void RequestOverride_WhenReasonIsEmpty_ShouldReturnRequiredError()
        {
            string result = _service.RequestOverride("Approved_and_Locked", "");
            Assert.Equal("Error: Modification reason is strictly required.", result); // التحقق من رفض السبب الفارغ
        }
    }
}