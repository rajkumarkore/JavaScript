var xmlHttp = createXmlHttpRequestObject();

function createXmlHttpRequestObject() {
    var xmlHttp;


    if (window.ActiveXObject) {
        try {
            xmlHttp = new ActiveXObject("microsoft.XMLHTTP");
        }
        catch (e) {
            xmlHttp = false;
        }
    } else {
        try {
            xmlHttp = new XMLHttpRequest();        } catch (e) {
            xmlHttp = false;
        }
    }
    if (!xmlHttp)
        alert("cant create that object loss");
    else
        return xmlHttp;
}
function process() {

    if (xmlHttp.readyState == 0 || xmlHttp.readyState == 4) {
        food = encodeURIComponent(Document.getElemenById("userInput").value);
        xmlHttp.open("GET", "foodstore.php?food=" + food, true);
        xmlHttp.onreadystatechange = handleServerResponse;
        xmlHttp.send(null);
    }
    else {
        settimeout('process()', 1000);
    }

}

function handleServerResponse() {
    if (xmlHttp.readyState == 4) {
        if (xmlHttp.status == 200) {
            xmlResponse = xmlHttp.xmlResponseXML;
            XMLDocumentElement = xmlResponse.documentElement;
            message = xmlDocumentElement.firstChild.data;
            document.getElementById("underInput").innerHTML =
                '<span style="color:blue">' + message + '</span>';
            settimeout('process()', 1000);
        } else {
            alert('something went wrong', 1000);
        }
    }

}
