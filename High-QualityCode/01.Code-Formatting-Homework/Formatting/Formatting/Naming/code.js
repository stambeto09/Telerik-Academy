var navigator;
var theLayer;
var b = navigator.appName;
var rating;
var addScroll = false;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) ||
    (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

var pX = 0;
var pY = 0;
var mouseMove;
var document;
document.onmousemove = mouseMove;

if (b === 'Netscape') {
    var Event;
    document.captureEvents(Event.MOUSEMOVE);
}

function popTip() {
    var window;
    if (b === 'Netscape') {
        theLayer = rating('document.layers[\'ToolTip\']');
        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }
        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = rating('document.all[\'ToolTip\']');
        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function hideTip() {
    if (b === "Netscape") {
        document.layers.ToolTip.visibility = 'hide';
    } else {
        document.all.ToolTip.style.visibility = 'hidden';
    }
}

function hideMenu1() {
    if (b === "Netscape") {
        document.layers.menu1.visibility = 'hide';
    } else {
        document.all.menu1.style.visibility = 'hidden';
    }
}

function showMenu1() {
    if (b === 'Netscape') {
        theLayer = rating('document.layers[\'menu1\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = rating('document.all[\'menu1\']');
        theLayer.style.visibility = 'visible';
    }
}

function hideMenu2() {
    if (b === "Netscape") {
        document.layers.menu2.visibility = 'hide';
    } else {
        document.all.menu2.style.visibility = 'hidden';
    }
}

function showMenu2() {
    if (b === 'Netscape') {
        theLayer = rating('document.layers[\'menu2\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = rating('document.all[\'menu2\']');
        theLayer.style.visibility = 'visible';
    }
}