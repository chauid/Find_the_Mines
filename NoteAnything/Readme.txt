프로그램 구조도
프로그램 작성시 참고 바람.(필독!)
※클래스 1개당 한 사람이 할당
※자신이 만든 클래스는 Class/[해당 개발자]/ 경로에 파일을 저장
즉, 사용자 정의 클래스는 partial 허용X

Form_A.cs // Class디렉토리 내에 파일 생성
Poject_NameSpace
{
    partial FormClass : Form // 폼
    {
        public Main() //메인 함수
        {
            '''
            Main() // 생성자
            {
                '''
            }
        }
    }
}

// A1.cs 외부 사용자1 정의 클래스 파일
Poject_NameSpace // 같은 네임스페이스
class AA // 사용자1 정의 클래스
{
    public void AA_1() //사용자 정의 메소드
    {
        '''
    }
}
class AB // 사용자 정의 클래스
{
    public int AB_1() //사용자 정의 메소드
    {
        '''
    }
}

// B1.cs 외부 사용자2 정의 클래스 파일
Poject_NameSpace // 같은 네임스페이스
class BB // 사용자2 정의 클래스
{
    public int CC_1() //사용자 정의 메소드
    {
        '''
    }
}

같은 디렉토리에 파일 생성
Form_A_partial.cs // 파일 이름 : [폼이름]_partial.cs
partial class FormClass 사용자 정의 메소드
{
    private int panelsize = 10; //예시
    public panelset() // Form클래스 내부 메소드
    {
        '''
    }
    폼 클래스 메소드 선언 및 구현
    
    private EventHandle(이벤트)
    {
        '''
        AA useAA = new AA();
        useAA.AA_1();
    }
}


----------에러날 시 읽을 것----------
[폼이름]_partial.cs는 폼 클래스를 상속받는 후 더블클릭 시
[폼이름]_partial.resx 파일이 생성되는데 이 파일은 중복 폼 선언으로 에러 발생
->해결방법 : [폼이름]_partial.resx 삭제
->[폼이름]_partial.cs 소스코드는 열고 싶으면
[폼이름]_partial.cs <- 이걸 말고
 └[폼 클래스 이름]을 <- 더블 클릭