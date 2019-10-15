#include<Windows.h>

LPTSTR lpstrArr[8] =
{
	(TCHAR*)"Sergo LOX?",
	(TCHAR*)"werwerwer",
(TCHAR*)"werwefdsf",
(TCHAR*)"werwerqr43",
(TCHAR*)"345234rtt",
(TCHAR*)"342t3retdhsgfj",
(TCHAR*)"opi;op;uiolyio",
(TCHAR*)"4574uyklhjgk"
};

INT WINAPI WinMain(HINSTANCE hinst, HINSTANCE hPrevInst, LPSTR lll, int Show) {

	int f = -1;
	for (size_t i = 0; i < 8; i++) {
		f = MessageBox(NULL, lpstrArr[i], TEXT("Questions"), MB_YESNOCANCEL);

		if (f == IDCANCEL) {
			break;
		}
	}	
	return NULL;
}