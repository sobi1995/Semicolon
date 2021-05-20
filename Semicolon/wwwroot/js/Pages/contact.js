 
$(document).ready(function () {

	function clearForm() {
		$('#form-contact').find("input[type=text] , textarea ").each(function () {
			$(this).val('');
		});
	}

	$("#btn-submit").click(function () {
		 
		var formData = $("#form-contact").serialize()
		$.ajax({
			type: "post",
			data:formData,
			url: "/Contact/Create",
			cache: false,
			success: function (response) {
				alert("success")
				clearForm();
			}, error: function (xhr) {
				 
				var errors = getErrors(xhr.responseJSON.errors)
				alert(errors)
			}
		});


	})

})