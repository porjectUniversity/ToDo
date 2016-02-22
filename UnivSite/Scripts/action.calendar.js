$(document).ready(function() {
    $("#jqxcalendar").jqxCalendar({ width: '780px', height: '600px' });
    $('#jqxcalendar').bind('valuechanged', function(event) {
        var date = event.args.date;
        $("#log").text(date.toDateString());
    });
});