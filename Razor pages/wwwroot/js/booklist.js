var datatable;

$(document).ready(function () {
	loadDataTable();
});

function loadDataTable() {
	datatable = $('#DT_load').DataTable({
		"ajax": {
			"url": "/api/book",
			"type": "GET",
			"datatype": "json"
		},
		"columns": [
			{ "data": "name", "width": "30%" },
			{ "data": "author", "width": "30%" },
			{ "data": "isbn", "width": "30%" },
			{
				"data": "id",
				"render": function (data) {
					return `<div class="text-center">
						<a href="booklist/edit?id={data}" class='btn btn-success text-white' style='cursor:pointer; width:100px'>
						Edit
						</a>
					&nbsp;
					<a class='btn btn-danger text-white' style='cursor:pointer; width:100px'>
					Delete
					</a>
					</div>`
				}, "width": "30%"
			}
		],
		"languages": {
			"emptytable": "no data found"
		},
		"width": "100%"
	});
}