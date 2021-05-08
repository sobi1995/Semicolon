

function getErrors(errors) {
	let result='';
	Object.keys(errors).forEach((item) => { result += errors[item]+'\n'})
	return result;
}