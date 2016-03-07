[root@cfzz-fgfj share-menu]# less ../../../cgi-bin/email/email.
email.cgi  email.pl
[root@cfzz-fgfj share-menu]# less ../../../cgi-bin/email/email.
email.cgi  email.pl
[root@cfzz-fgfj share-menu]# less ../../../cgi-bin/email/email.pl
[root@cfzz-fgfj share-menu]# vi share
sharemenu.jQuery.js  share-menu.php
[root@cfzz-fgfj share-menu]# vi sharemenu.jQuery.js
[root@cfzz-fgfj share-menu]# vi share-menu.php
[root@cfzz-fgfj share-menu]# vi ../../../cgi-bin/email/email.pl
#!/usr/sbin/perl -T
use strict;
use warnings;
use 5.008;

use Data::Dumper;
use CGI;
my $q = CGI->new;

my %data;
$data{toemail} = $q->param('toemail');
$data{fromemail} = $q->param('fromemail');
$data{comment} = $q->param('comment');

print $q->header;
print "response " . Dumper \%data;

$ENV{PATH} = '';
sendmail(
    'Target <tundemoran@gmail.com>',
    'check this article from walrus',
    'submitted: ' . Dumper(\%data),
    'Source <obama@whitehouse.gov>');

sub sendmail {
    my ($tofield, $subject, $text, $fromfield) = @_;
    my $mailprog = "/usr/sbin/sendmail";

    open my $ph, '|-', "$mailprog -t -oi" or die $!;
    print $ph "To: $tofield\n";
    print $ph "From: $fromfield\n";
    print $ph "Reply-To: $fromfield\n";
    print $ph "Subject: $subject\n";
    print $ph "\n";
    print $ph "$text";
    close $ph;
    return ;
}

