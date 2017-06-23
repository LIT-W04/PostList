$(function() {
    var count = 1;

    $("#add-row").on('click', function() {
        //$("table").append(`<tr><td>
        //                <input type="text" name="icecreams[${count}].flavor" placeholder="Flavor" class="form-control" />
        //            </td>
        //            <td>
        //                <input type="text" name="icecreams[${count}].price" placeholder="Price" class ="form-control" />
        //            </td>
        //            <td>
        //                <input type="checkbox" value="true" name="icecreams[${count}].iswithcone" class ="form-control" />
        //                <input type="hidden" value="false" name="icecreams[${count}].iswithcone" />
        //            </td></tr>`);

        var html = $("#template").html();
        html = html.replace(/0/g, `${count}`);
        $("table").append("<tr>" + html + "</tr>");
        count++;
    });
});




