$(document).ready(function() {
    $("#jqxcalendar").jqxCalendar({ width: '800px', height: '700px' });
    $('#jqxcalendar').bind('valuechanged', function(event) {
        var date = event.args.date;
        $("#log").text(date.toDateString());
    });
});