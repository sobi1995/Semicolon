 
$(document).ready(function () {
 
	$("#btn-submit").click(function () {
		debugger
		var formData = $("#form-contact").serialize()
		$.ajax({
			type: "post",
			data:formData,
			url: "/Contact/Create",
			cache: false,
			success: function (response) {
				console.log(response);
			}, error: function (xhr) {
				 
				var errors = getErrors(xhr.responseJSON.errors)
				alert(errors)
			}
		});


	})

})