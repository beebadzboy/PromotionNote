window.onload = function () {
    document.ontouchend = function () {
        isOnscroll(headerScroll)
    }
}
//å–å€¼ã€èµ‹å€¼scrollTop
function topAll(i) {
    if (document.documentElement.scrollTop) {
        if (!i) return document.documentElement.scrollTop //å–å€¼
        document.documentElement.scrollTop = i; //èµ‹å€¼
    } else if (document.body.scrollTop) {
        if (!i) return document.body.scrollTop; //å–å€¼
        document.body.scrollTop = i; //èµ‹å€¼
    } else {
        if (!i) return window.pageYOffset;
        window.pageYOffset = i
    }
}
//å…ˆåˆ¤æ–­æ˜¯å¦æ­£åœ¨æ»šåŠ¨
function isOnscroll(callback) {
    var topValue = 0, // ä¸Šæ¬¡æ»šåŠ¨æ¡åˆ°é¡¶éƒ¨çš„è·ç¦»  
        interval = null, // å®šæ—¶å™¨
        isListen;
    var handler = function () {
        isListen = true;
        topValue = topAll();
        if (interval == null) {
            interval = setInterval(function () {
                if (topAll() == topValue) {
                    clearInterval(interval);
                    interval = null;
                    document.removeEventListener('scroll', handler);
                    //æ»šåŠ¨åœæ­¢åŽæ‰§è¡Œ
                    callback()
                }
            }, 50)
        }

    }
    document.addEventListener('scroll', handler)
    setTimeout(function () {
        if (!isListen)
            callback()
    }, 50)
}
//t=0,t++,bæ»šåŠ¨æ¡å½“å‰ä½ç½®ï¼Œcä»£è¡¨è¦ç§»åŠ¨åˆ°ä½ç½®å’Œæœ¬èº«ä½ç½®çš„å·®å€¼,dåˆ†å¤šå°‘æ¬¡åˆ°
function tt(t, b, c, d) {
    return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
}

var beforeScrollTop = topAll();

//headerå¤´å›¾æ»šåŠ¨
function headerScroll() {
    var height = document.getElementById('header').offsetHeight;
    var current = topAll();
    if (current > height / 3 && current < height) {
        var distance = height - current;
        var afterScrollTop = topAll();
        var delta = afterScrollTop - beforeScrollTop; //åˆ¤æ–­å‘ä¸‹æ»šåŠ¨è¿˜æ˜¯å‘ä¸Šæ»šåŠ¨

        if (delta == 0) {
            return false;
        } else if (delta > 0) {
            var j = 0;

            function smoothDown() {
                var scrollTop = topAll();
                if (scrollTop < height) {
                    topAll(tt(j, current, distance, 20))
                    j++;
                    setTimeout(smoothDown, 20)
                } else {
                    topAll(height);
                    beforeScrollTop = topAll()
                    j = 0;
                }
            }
            smoothDown()
        } else {
            var i = 0;

            function smoothUp() {
                var scrollTop = topAll();
                if (scrollTop > 0 && scrollTop < height) {
                    topAll(tt(i, current, -distance, 10));
                    i++;
                    setTimeout(smoothUp, 20)
                } else if (scrollTop <= 0) {
                    topAll(0);
                    beforeScrollTop = topAll()
                    i = 0;
                }
            }
            //			smoothUp()
        }
    }

}